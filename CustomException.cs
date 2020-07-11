using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BusinessLogicLayer
{
    public class CustomException
    {
        public void ClientIDAlreadyExist()
        {
            try
            {

                throw new ClientIDAlreadyExist("The client ID already exists, try to reinsert the client");
            }
            catch (ClientIDAlreadyExist catcher)
            {

                throw;
            }
        }
    }
    public class ClientIDAlreadyExist : Exception
    {
        public ClientIDAlreadyExist()
        {

        }
        public ClientIDAlreadyExist(string message)
            :base(message)
        {

        }

    }
}
