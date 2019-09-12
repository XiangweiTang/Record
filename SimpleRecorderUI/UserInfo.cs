using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorderUI
{
    class UserInfo
    {
        public Guid UserGuid { get; }
        public string UserId { get; set; } = "";
        public byte Age { get; set; } = 0;
        public string Gender { get; set; } = "U";
        public string Dialect { get; set; } = "U";
        public UserInfo()
        {
            UserGuid = Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"{UserGuid.ToString()}\t{UserId}\t{Age}\t{Gender}\t{Dialect}";
        }
    }
}
