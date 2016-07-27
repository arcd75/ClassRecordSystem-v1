using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRecordSystem.Models
{
    public class MethodsClass
    {
        public static string GetNextCode(List<string> numbersList)
        {
            string num = "0000001";
            if (numbersList.Count() > 0)
            {
                numbersList = numbersList.OrderByDescending(c => c).ToList();
                string lastNumber = numbersList.FirstOrDefault();
                int nextNumber = int.Parse(lastNumber) + 1;
                num = "";
                for (int i = nextNumber.ToString().Length; i < 8; i++) { num += "0"; }
                num += nextNumber.ToString();
            }

            return num;
        }
    }
}
