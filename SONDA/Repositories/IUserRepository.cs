using SONDA.Models;

namespace SONDA.Repositories;

public interface IUserRepository
{
    public Task<List<UserModel>> GetAll();
}