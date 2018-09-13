using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole {
    public class PlayerCharacter {

        //    public PlayerCharacter() {
        //        DateOfBirth = null;
        //        DaySinceLastLogin = null;
        //   }
        public PlayerCharacter(SpecialDefence specialDefence) {
            _specialDefence = specialDefence;
        }
        private readonly SpecialDefence _specialDefence;
        public string Name { get; set; }
        public int? DaySinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNew { get; set; }
        public int Health { get; set; } = 100;

        public void Hit(int damage) {
            int damageReduction = 0;
            //if (_specialDefence != null) {
            //    damageReduction = _specialDefence.CalculateDamageReduction(damage);
            //}
            //int totalDamageTaken = damage - damageReduction;

            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);
            Health -= totalDamageTaken;
            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}");
        }


    }
}
