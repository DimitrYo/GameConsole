﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole {
    class DiamondSkinDefense : SpecialDefence {
        public override int CalculateDamageReduction(int totalDamage) {
            return 1;
        }
    }
}