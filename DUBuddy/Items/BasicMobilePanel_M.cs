﻿using System;
using System.Collections.Generic;

using DUBuddy.IndustryBuildings;

namespace DUBuddy.Items
{
    internal class BasicMobilePanel_M : IItem
    {
        public TimeSpan GetBuildTime()
        {
            return TimeSpan.FromMinutes(9);
        }

        public string GetName()
        {
            return "Basic Mobile Panel M";
        }

        public bool isOre()
        {
            return false;
        }

        public int GetProductionAmount()
        {
            return 1;
        }

        public double GetProductionProMinute()
        {
            TimeSpan s = GetBuildTime();
            int amount = GetProductionAmount();

            return amount / s.TotalMinutes;
        }

        public Type GetIndustryBuildingType()
        {
            return typeof(MetalworkM_Building);
        }

        private Dictionary<Type, int> recipe = new Dictionary<Type, int>()
            {
                {typeof(BasicScrew), 25},
                {typeof(Silumin), 49 }
            };

        public Dictionary<Type, int> GetRecipe()
        {
            return recipe;
        }

        public int GetUnitMinPrice()
        {
            return 2672;
        }

        public int GetUnitMaxPrice()
        {
            return 10000;
        }
    }
}
