using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoWagenpark
{
    public class WagenparkDBManager
    {
        private static ConnectionStringSettings conWagenParkSetting =
          ConfigurationManager.ConnectionStrings["WagenPark"];
        private static DbProviderFactory factory =
            DbProviderFactories.GetFactory(conWagenParkSetting.ProviderName);

        public DbConnection GetConnection()
        {
            var conWagenPark= factory.CreateConnection();
            conWagenPark.ConnectionString = conWagenParkSetting.ConnectionString;
            return conWagenPark;
        }
    }
}
