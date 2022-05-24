using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Interfaces
{
    interface IBancoIntermediario<Tipo>
    {
        void Insert(Tipo tipo);

        void Update(Tipo tipo);

        void Delete(Tipo tipo);

        List<Tipo> List();

        Tipo GetById(string Codigo);
    }
}
