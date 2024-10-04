using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConfiguratorNewest.BLL
{
    public class EmbeddedBLL
    {

        public static bool IsValidIP(string Address)
        {
            //Match pattern for IP address    
            string Pattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            //Regular Expression object    
            Regex check = new Regex(Pattern);

            //check to make sure an ip address was provided    
            if (string.IsNullOrEmpty(Address))
                //returns false if IP is not provided    
                return false;
            else
                //Matching the pattern    
                return check.IsMatch(Address, 0);
        }

        public static Color ChoiceColor(String msg)
        {
            if (String.IsNullOrEmpty(msg)) return Color.DimGray;

            if (msg.ToUpper().Contains("PLEASE WAIT")) return Color.DarkBlue;
            if (msg.ToUpper().Contains("ERROR")) return Color.Red;
            if (msg.ToUpper().Contains("STATE_STOP_APP_START")) return Color.Orange;
            if (msg.ToUpper().Contains("STATE_UNINSTALL_START")) return Color.OrangeRed;
            if (msg.ToUpper().Contains("STATE_REBOOT_START")) return Color.DarkBlue;
            if (msg.ToUpper().Contains("STATE_START_APP_START")) return Color.Green;
            if (msg.ToUpper().Contains("DURATION")) return Color.Black;
            if (msg.ToUpper().Contains("STARTING...")) return Color.Black;
            if (msg.ToUpper().Contains("FINISHED.")) return Color.Black;
            if (msg.ToUpper().Contains("SUCCESS")) return Color.Green;
            else return Color.DimGray;
        }



    }
}
