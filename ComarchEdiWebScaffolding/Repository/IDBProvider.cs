using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace webMock.Repository
{
  public interface IDBProvider
  {
    bool CheckValidation();
    SqlDataReader ExecuteSPToDataReader(string spName, List<SqlParameter> spParams);
    DataSet ExecuteSPToDS(string spName, List<SqlParameter> spParams);
    void ExecuteSP(string spName, List<SqlParameter> spParams);
    T ExecuteSPWithOutputParam<T>(string spName, List<SqlParameter> spParams, SqlParameter outParam);
  }
}
