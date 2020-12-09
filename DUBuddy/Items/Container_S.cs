﻿using System;
using System.Collections.Generic;

using DUBuddy.IndustryBuildings;

namespace DUBuddy.Items
{
    class Container_S : IItem
    {
        public TimeSpan GetBuildTime()
        {
            return TimeSpan.FromMinutes(24);
        }

        public string GetName()
        {
            return "Container S";
        }

        public bool isOre()
        {
            return false;
        }

        public int GetProductionAmount()
        {
            return 1;
        }

        public Type GetIndustryBuildingType()
        {
            return typeof(AssemblyLineM_Building);
        }

        public double GetProductionProMinute()
        {
            TimeSpan s = GetBuildTime();
            int amount = GetProductionAmount();

            return amount / s.TotalMinutes;
        }

        private Dictionary<Type, int> recipe = new Dictionary<Type, int>()
            {
                {typeof(BasicReinforcedFrame_M), 1},
                {typeof(BasicHydraulic), 24},
                {typeof(BasicComponent), 36},
            };

        public Dictionary<Type, int> GetRecipe()
        {
            return recipe;
        }

        public int GetUnitMinPrice()
        {
            return 13000;
        }

        public int GetUnitMaxPrice()
        {
            return 30000;
        }
    }
}
