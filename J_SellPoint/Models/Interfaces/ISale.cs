using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_SellPoint.Models.Interfaces
{
    interface ISale
    {
        bool Save(Product p, int units);
        List<Sale> GetSalesList(int? prod, int? month, int? year);
        DataTable GetSalesTable(int? prod, int? month, int? year);
    }
}
