using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole {
    public class PlayerDisplayer {
        public static void Write(PlayerCharacter player) {

            int days = player.DaySinceLastLogin.GetValueOrDefault(-1);
            Console.WriteLine($"{days} since last login");

            if (string.IsNullOrWhiteSpace(player.Name)) {
                Console.WriteLine("Player name is null or whitespaces");
            }
            else {
                Console.WriteLine(player.Name);
            }

            //if (player.DaySinceLastLogin.HasValue) {
            //    Console.WriteLine(player.DaySinceLastLogin.Value);
            //}
            //else {
            //    Console.WriteLine("No value for DaysSinceLastLogin");
            //}

            if (player.DateOfBirth.HasValue) {
                Console.WriteLine(player.DateOfBirth);
            }
            else {
                Console.WriteLine("No date of birth specified");
            }

            if (player.IsNew == null) {
                Console.WriteLine("Player newbie status is unwknown");
            }
            else if (player.IsNew == true) {
                Console.WriteLine("Player is a newbie");
            }
            else {
                Console.WriteLine("Player is a expirienced");
            }
        }
    }
}
