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
        public string Name { get; set; }
        public int? DaySinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? IsNew { get; set; }

    }
}
