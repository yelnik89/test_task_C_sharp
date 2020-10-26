using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task
{
    class ClientServise
    {
        private AppContext Db;

        public ClientServise()
        {
            Db = new AppContext();
        }

        public void AddClients(List<string[]> clientsData)
        {
            foreach(string[] clientData in clientsData)
            {
                Db.Clients.Add(Client.CreateClient(clientData));
            }
        }

        public void SaveChengesInDb()
        {
            Db.SaveChanges();
        }
    }
}
