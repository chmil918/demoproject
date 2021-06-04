using BLL.DTO;
using System.Collections.Generic;

namespace BLL.Services.Abstract
{
    public interface ITestService
    {
        IEnumerable<TestDTO> GetAll();
        TestDTO Get(int id);
        void Create(TestDTO model);
        void Update(TestDTO model);
        void Delete(int id);
    }
}
