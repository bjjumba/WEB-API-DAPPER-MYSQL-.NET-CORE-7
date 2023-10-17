namespace SONDA.Repositories;
using SONDA.Models;

public interface IBranchRespository
{
    Task<IEnumerable<Branch>> GetAllAsync();
    Task<Branch> GetByIdAsync(Int64 id);
    Task Create(Branch _Branch);
    Task Update(Branch _Branch);
    Task Delete(Int64 id);
}