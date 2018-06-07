using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_SellPoint.Models.Interfaces
{
    public interface IProduct
    {
        bool Save();
        void Load(int id);
        bool Update();
        bool AddQuantity(int id, int plus);
        List<Product> GetAllProducts();
        DataTable GetProductsTable();
        List<Product> GetProductsByNameList(string desc);
        DataTable GetProductsByNameTable(string desc);
        DataTable GetProductsByPriceRangeTable(string desc);
        List<Product> GetProductsByPriceRangeList(string desc);
    }
}
