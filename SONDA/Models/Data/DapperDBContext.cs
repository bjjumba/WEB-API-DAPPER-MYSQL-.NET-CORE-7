using System.Data;
using MySql.Data.MySqlClient;

namespace SONDA.Models.Data;

public class DapperDBContext
{
    public readonly IConfiguration _configuration;
    private readonly string connectionString;

    public DapperDBContext(IConfiguration _configuration)
    {
        this._configuration = _configuration;
        this.connectionString = this._configuration.GetConnectionString("MysqlConn");
    }
    /*Dapper Connection interface*/

    public IDbConnection CreateConnection() => new MySqlConnection(connectionString);
}