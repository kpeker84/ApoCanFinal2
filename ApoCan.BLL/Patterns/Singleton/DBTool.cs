using ApoCan.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoCan.BLL.Patterns.Singleton
{
    public class DBTool
    {

        private DBTool() { }

        private static ApocanContext _dbInstance;

        public static ApocanContext DBInstance
        {
            get
            {

                if (_dbInstance == null)
                {

                    _dbInstance = new ApocanContext();
                }

                return _dbInstance;

            }
        }












    }
}
