using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRecorder
{
    class Config
    {
        public string TransPath { get; private set; } = "";
        public string AudioRootPath { get; private set; } = "";
        public string RecordPath { get; private set; } = "";
    }
}
