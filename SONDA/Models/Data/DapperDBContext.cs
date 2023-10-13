using System.Data;
using MySql.Data.MySqlClient;
using SONDA.Repositories;

namespace SONDA.Models.Data;

public class DapperDBContext 
{
    private readonly IConfiguration _configuration;
  //  private readonly string connectionString;
    

    public DapperDBContext(IConfiguration configuration)
    {
        _configuration = configuration;
       // connectionString = this._configuration.GetConnectionString("MysqlConn");
    }
    /*Dapper Connection interface*/

    public IDbConnection CreateConnection() => new MySqlConnection(_configuration.GetConnectionString("MySqlConn"));
    
}