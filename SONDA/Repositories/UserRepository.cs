using Dapper;
using SONDA.Models;
using SONDA.Models.Data;

namespace SONDA.Repositories;

public class UserRepository:IUserRepository
{
    private readonly DapperDBContext _context;
    
    public UserRepository(DapperDBContext context)
    {
        _context = context;
    }
    public async Task<List<UserModel>> GetAll()
    {
        string? query = "SELECT * FROM users";
        using (var connection = _context.CreateConnection())
        {
            connection.Open();
            var users = await connection.QueryAsync<UserModel>(query);
            return users.ToList();
        }
    }
}