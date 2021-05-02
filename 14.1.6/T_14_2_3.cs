using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_Homework_5
{
    class T_14_2_3
    {
        public void Task_14_2_3()
        {
            /*14.2.3.შექმენით 9-10 - ელემენტიანი სტეკი.წაიკითხეთ და ეკრანზე გამოიტანეთ სტეკის
            უკანასკნელი ელემენტის მნიშვნელობა მისი წაშლის გარეშე.ეკრანზე გამოიტანეთ სტეკში
            არსებული ელემენტების რაოდენობა და სტეკის ყველა ელემენტი. სტეკიდან ყველა ელემენტი
            წაშალეთ.*/

             Stack<string> stack = new Stack<string>();
             stack.Push("A");
             stack.Push("l");
             stack.Push("e");
             stack.Push("x");
             stack.Push("a");
             stack.Push("n");
             stack.Push("d");
             stack.Push("r");
             stack.Push("e");
            
            Console.WriteLine($"Stack-is ukanaskneli elementi { stack.Peek()}");

            Console.WriteLine();
            Console.WriteLine($"Amount of elements:{stack.Count()}");

            Console.WriteLine();

            foreach (var item in stack)
            {
                Console.Write(item);
            }

            while(stack.Count > 0)
            {
                stack.Pop();
            }
            Console.WriteLine();
            Console.WriteLine($"Amount of elements:{stack.Count()}");
        }
    }
}
