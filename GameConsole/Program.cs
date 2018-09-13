using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole {
    class Program {
        static void Main(string[] args) {
            //var player = new PlayerCharacter();

            //player.DaySinceLastLogin = 42;
            // PlayerDisplayer.Write(player);

            // int days = player.DaySinceLastLogin.Value;


            // PlayerCharacter player = null;

            // int days = player?.DaySinceLastLogin ?? -1;

            // int days;
            //if (player != null) {
            //    days = player.DaySinceLastLogin ?? -1;
            //}
            //else {
            //    days = -1;
            //}

            // Console.WriteLine(days);


            //PlayerCharacter[] players = new PlayerCharacter[3] {
            //    new PlayerCharacter { Name = "Sarah"},
            //    new PlayerCharacter(),
            //    null
            //};

            //PlayerCharacter[] players = null;

            //string p1 = players?[0]?.Name;
            //string p2 = players?[1]?.Name;
            //string p3 = players?[2]?.Name;

            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefense()) {
                Name = "Sarah"
            };

            PlayerCharacter amrit = new PlayerCharacter(new IronBonesDefense()) {
                Name = "Amrit"
            };

            PlayerCharacter gentry = new PlayerCharacter(SpecialDefence.Null) {
                Name = "Gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);

            Console.ReadLine();
        }
    }
}
