using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Common
{
    public class Settings
    {
        public DatabaseSetting Database { get; set; }
    }

    public class DatabaseSetting
    {
        public string ConnectionString { get; set; }
    }
}
