using System;
using System.Collections.Generic;
using System.Text;

namespace se307Project
{
    class Admin : User
    {
        // The Admin private constructor
        // No client can instantiate an Admin object
        private Admin() { }

        // The private reference to the one and only instance
        private static Admin singleInstance = null;

        // Returns a reference to the single instance
        // Creates the instance if it does not yet exist
        public static Admin GetInstance()
        {
            if (singleInstance == null)
            {
                singleInstance = new Admin();
            }

            return singleInstance;
        }
    }
}
