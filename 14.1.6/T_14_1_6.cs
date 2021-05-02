using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_Homework_5
{
    class T_14_1_6
    {
        public void Task_14_1_6()
        {
            
            
            /* შექმენით 5-10 - ელემენტიანი ჰეშ - ცხრილი.ჰეშ - ცხრილში შეასრულეთ ძებნა გასაღებისა და
             სიდიდის მიხედვით. ნაპოვნი გასაღები და სიდიდე ეკრანზე გამოიტანეთ. ეკრანზე გამოიტანეთ
             ჰეშ - ცხრილში ელემენტების რაოდენობა და ყველა გასაღები და ყველა სიდიდე.*/

            Hashtable has = new Hashtable();
            has.Add("Name", "Alexandre");
            has.Add("Lname", "Iavriani");
            has.Add("Age", "20");
            has.Add("Mobile", "111120036");
            has.Add("University", "GAU");
           

            if (has.ContainsKey("Age"))
            {
                Console.WriteLine($"Key Age is exist");
            }
            else
            {
                Console.WriteLine($"Key Age is not exist");
            }

            Console.WriteLine();

            if (has.ContainsValue("GTU"))
            {
                Console.WriteLine($"Value GTU is exist");
            }
            else
            {
                Console.WriteLine($"Value GTU is not exist");
            }
            

            Console.WriteLine();

            foreach (DictionaryEntry item in has)
            {
                Console.WriteLine($"Key:{item.Key},Value:{item.Value}");
                
            }
            Console.WriteLine();
            Console.WriteLine($"Amount of elements:{has.Count}");
           //Console.ReadKey();
        }
    }
}
