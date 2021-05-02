using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_Homework_5
{
    class T_14_2_1
    {
        public void Task_14_2_1()
        {
            /*14.2.1.შექმენით 9-10 - ელემენტიანი რიგი.წაიკითხეთ და ეკრანზე გამოიტანეთ რიგის I ელემენტის
            მნიშვნელობა მისი წაშლის გარეშე.ეკრანზე გამოიტანეთ რიგში არსებული ელემენტების
            რაოდენობა და რიგის ყველა ელემენტი. რიგიდან ყველა ელემენტი წაშალეთ.*/

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("l");
            queue.Enqueue("e");
            queue.Enqueue("x");
            queue.Enqueue("a");
            queue.Enqueue("n");
            queue.Enqueue("d");
            queue.Enqueue("r");
            queue.Enqueue("e");

            Console.WriteLine();

            Console.WriteLine($"First Element:{queue.Peek()}");
            Console.WriteLine();

            Console.WriteLine($"Amount of elements:{queue.Count()}");

            Console.WriteLine();   

            while(queue.Count > 0)
            {
                Console.Write(queue.Dequeue());
            }
                
            Console.WriteLine();
            Console.WriteLine($"Amount of elements:{queue.Count()}");

        }
    }
}
