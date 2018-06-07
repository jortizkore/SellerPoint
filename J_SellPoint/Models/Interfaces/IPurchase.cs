﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J_SellPoint.Models.Interfaces
{
    interface IPurchase
    {
        bool Save(Product p, int units);
        List<Purchase> GetPurchaseslList(int? month, int? year);
        DataTable GetPurchaseslTable(int? month, int? year);
    }
}
