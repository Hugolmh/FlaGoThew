using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaGoThew.model.utils
{
    public class HashUtil
    {
        public static string Hash(string str)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(str, 13);
        }
    }
}
