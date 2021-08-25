﻿using RimWorld;
using Verse;

namespace AOMoreFurniture
{
    [DefOf]
    public static class HediffDefOf
    {
        public static HediffDef Computer_LearningBoost;

        static HediffDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
        }
    }
}