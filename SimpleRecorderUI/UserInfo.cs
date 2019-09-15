using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorderUI
{
    class UserInfo
    {
        public string UserId { get; set; } = "";
        public byte Age { get; set; } = 0;
        public string Gender { get; set; } = "U";
        public string Dialect { get; set; } = "U";
        public UserInfo()
        {
        }
        public void Load(params string[] args)
        {
            UserId = args[0];

            try { Age = byte.Parse(args[1]); }
            catch { Age = 20; }

            switch (args[2])
            {
                case "男":
                    Gender = "M";
                    break;
                case "女":
                    Gender = "F";
                    break;
                default:
                    Gender = "U";
                    break;
            }

            if (!string.IsNullOrWhiteSpace(args[3]))
                Dialect = args[3];
        }
        public override string ToString()
        {
            return $"{UserId}\t{Age}\t{Gender}\t{Dialect}";
        }
    }
}
