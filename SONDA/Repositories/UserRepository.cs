using Dapper;
using SONDA.Models;
using SONDA.Models.Data;

namespace SONDA.Repositories;

public class UserRepository:IUserRepository
{
    public readonly DapperDBContext _context;
    
    public UserRepository(DapperDBContext _context)
    {
        this._context = _context;
    }
    public async Task<List<UserModel>> GetAll()
    {
        string query = "SELECT * FROM users";
        using (var connection = this._context.CreateConnection())
        {
            var users = await connection.QueryAsync<UserModel>(query);
            return users.ToList();
        }
    }
}