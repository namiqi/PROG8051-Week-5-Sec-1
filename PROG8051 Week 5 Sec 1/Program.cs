

using System;


namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays


            // Exercise: ATM

            string[,] Accounts = { { "John", "Smith", "1234", "10000" }, { "Leo", "Messi", "1010", "20000" } };


            bool logged = false;
            int userID = 0;

            while (!logged)
            {
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Please enter your psw: ");
                string psw = Console.ReadLine();


                for (int i = 0; i < Accounts.GetLength(0); i++)
                {
                    for (int j = 0; j < Accounts.GetLength(1); j++)
                    {
                        if (Accounts[i, 0].Equals(name))
                        {
                            if (Accounts[i, 2].Equals(psw))
                            {
                                Console.WriteLine("You are logged in");
                                logged = true;
                                userID = i;
                                break;
                            }
                        }
                    }

                }

            }

            Console.WriteLine("Please choose action: \n 1. Check Balance \n 2. Withdraw \n 3. Deposit ");

            Console.WriteLine("Please enter your choice: ");
            string choice = Console.ReadLine();

            if(choice == "1")
            {
                Console.WriteLine(Accounts[userID, 3]);
            }


            //2D Arrays

            string[,] students = { { "A", "AA", "1" }, { "B", "BB", "1" } };

            // How to access 2D array

            Console.WriteLine(students[0,1]);


            // How to change an element of an Array

            students[0, 2] = "3";

            Console.WriteLine("---------------------------");
            // Looping through 2D array

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("---------------------------");
            // The length of 2D array

            for (int i = 0; i < students.GetLength(0); i++)
            {
                for(int j = 0; j < students.GetLength(1); j++)
                {
                    Console.WriteLine(students[i, j]);
                }
                
            }
            Console.WriteLine("---------------------------");
            // How to create an Array

            string[] names = { "John", "Prateek", "Daniel" };

            int[] evennumbers = { 2, 4, 6, 8 };

            Array.Reverse(evennumbers);


            for (int i = 0; i < evennumbers.Length; i++)
            {
                Console.WriteLine(evennumbers[i]);
            }

            Console.WriteLine("min is : " + evennumbers.Min());
            Console.WriteLine("max is : " + evennumbers.Max());
            Console.WriteLine("sum is : " + evennumbers.Sum());

            int[] numbersArray = Enumerable.Range(1, 100).ToArray();

            int countDiv3and4 = 0;
            int sumDiv3and4 = 0;
            foreach(int number in numbersArray)
            {
                if(number %3== 0 && number % 4 == 0)
                {
                    Console.WriteLine(number);
                    countDiv3and4++;
                    sumDiv3and4 += number;
                }


            }
            Console.WriteLine(countDiv3and4);
            Console.WriteLine(sumDiv3and4);








            // ForEach loop

            foreach (string apple in names)
            {
                Console.WriteLine(apple);
            }




            // Looping throught an Array

            int countLongNames = 0;

            for(int i = 0; i < names.Length; i++)
            {
                if (names[i].Length >5)
                {
                    countLongNames++;

                }
               
            }
            Console.WriteLine($"{countLongNames} names have more than 5 chars");



            // How to access the element of the Arrays

            Console.WriteLine(evennumbers[0]);

            // Access last element of an array using Length property

            Console.WriteLine(evennumbers[evennumbers.Length-1]);

            // Length of Array

            Console.WriteLine(evennumbers.Length);

            // Change the element of an Array

            names[0] = "Jatin";
            Console.WriteLine(names[0]);




        }
    }
}