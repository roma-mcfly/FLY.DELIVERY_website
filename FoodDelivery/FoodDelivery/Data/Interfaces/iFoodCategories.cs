﻿using FoodDelivery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDelivery.Data.interfaces
{
    public interface iFoodCategories
    {
        IEnumerable<FoodCategory> AllFoodCategories { get; }
    }
}
