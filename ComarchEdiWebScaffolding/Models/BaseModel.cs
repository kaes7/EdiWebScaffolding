using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webMock.Models
{
  public class BaseModel : IModel
  {
    public int Id
    {
      get;
      set;
    }
  }
}
