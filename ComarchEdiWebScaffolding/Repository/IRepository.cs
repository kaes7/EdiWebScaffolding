using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webMock.Models;

namespace ComarchEdiWebScaffolding.Repository
{
  public interface IRepository<T> where T: IModel
  {
    void Add(T modelItem);
    void Edit(T modelItem);
    void Delete(T modelItem);
    void Update(T modelItem);
    IEnumerable<T> Get();
    void DoAction(Action<T> action);
  }
}
