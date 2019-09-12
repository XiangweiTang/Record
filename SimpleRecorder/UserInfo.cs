using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorder
{
    class UserInfo
    {
        public Guid UserId { get; private set; } = new Guid();
        public byte Age { get; private set; } = 0;
        public bool Gender { get; private set; } = true;
        public UserInfo(byte age, bool gender)
        {
            UserId = Guid.NewGuid();
            Age = age;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"{UserId.ToString()}\t{Age}\t{Gender}";
        }
    }
}
