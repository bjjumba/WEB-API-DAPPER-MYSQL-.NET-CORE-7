using SONDA.Models;

namespace SONDA.Repositories;

public interface IUserRepository
{
    Task<List<UserModel>> GetAll();
    
}