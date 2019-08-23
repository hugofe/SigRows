using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigRows.Models.Interface
{
    public interface IRowService
    {
        Row Create(Row row);
        Row Read(Row row);
        IEnumerable<Row> ReadAll();
        void Update(int id);
        void Delete(int id);
    }
}
