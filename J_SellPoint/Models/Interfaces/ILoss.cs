using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_SellPoint.Models.Interfaces
{
    public interface ILoss
    {
        void Load(int id);
        bool Save(Product p, int quantity);
        DataTable GetLossesTable(int? month, int? year);
        List<Loss> GetLossesList(int? month, int? year);
        List<Loss> GetLossesFromAProductList(int ProdID);
        DataTable GetLossesFromAProductTable(int ProdID);


    }
}
