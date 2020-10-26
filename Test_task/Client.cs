using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task
{
    class Client
    {
        public int Id { get; set; }
        public string BudgetCode { get; set; }
        public bool IsActive { get; set; }
        public int SinAccount { get; set; }
        public int KOSGU { get; set; }
        public float StartYearAll { get; set; }
        public float StartYearLong { get; set; }
        public float StartYearOverdue { get; set; }
        public float IncreaseIndebtednessAll { get; set; }
        public float IncreaseIndebtednessNotMoney { get; set; }
        public float DecreaseIndebtednessAll { get; set; }
        public float DecreaseIndebtednessNotMoney { get; set; }
        public float EndYearAll { get; set; }
        public float EndYearLong { get; set; }
        public float EndYearOverdue { get; set; }
        public float EndYearAllPast { get; set; }
        public float EndYearLongPast { get; set; }
        public float EndYearOverduePast { get; set; }

        public static Client CreateClient(string[] array)
        {
            Client client = new Client();
            client.BudgetCode = array[0];
            client.IsActive = array[1].Equals("1") ? true : false;
            client.SinAccount = Convert.ToInt32(array[2]);
            client.KOSGU = Convert.ToInt32(array[3]);
            client.StartYearAll = Convert.ToSingle(array[4]);
            client.StartYearLong = Convert.ToSingle(array[5]);
            client.StartYearOverdue = Convert.ToSingle(array[6]);
            client.IncreaseIndebtednessAll = Convert.ToSingle(array[7]);
            client.IncreaseIndebtednessNotMoney = Convert.ToSingle(array[8]);
            client.DecreaseIndebtednessAll = Convert.ToSingle(array[9]);
            client.DecreaseIndebtednessNotMoney = Convert.ToSingle(array[10]);
            client.EndYearAll = Convert.ToSingle(array[11]);
            client.EndYearLong = Convert.ToSingle(array[12]);
            client.EndYearOverdue = Convert.ToSingle(array[13]);
            client.EndYearAllPast = Convert.ToSingle(array[14]);
            client.EndYearLongPast = Convert.ToSingle(array[15]);
            client.EndYearOverduePast = Convert.ToSingle(array[16]);
            return client;
        }
    }
}
