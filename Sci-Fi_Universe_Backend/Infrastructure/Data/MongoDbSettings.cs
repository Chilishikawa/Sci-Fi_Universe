using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }

        public string Characters{ get; set; }
    }
}
