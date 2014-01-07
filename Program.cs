using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleArrayListPresidents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            ArrayList oPresidentsList = new ArrayList();
            String sUserResp = String.Empty;
            
            //Instruct the user
            Pause("I will show you a list of all of the Presidents of the United States," +
                  "\nin alphabetical order, by last name.");

            //Create the list of Presidents
            oPresidentsList.Add("Washington, George");
            oPresidentsList.Add("Adams, John");
            oPresidentsList.Add("Jefferson, Thomas");
            oPresidentsList.Add("Madison, James");
            oPresidentsList.Add("Monroe, James");
            oPresidentsList.Add("Adams, John Quincy");
            oPresidentsList.Add("Jackson, Andrew");
            oPresidentsList.Add("Buren, Martin Van");
            oPresidentsList.Add("Harrison, William Henry");
            oPresidentsList.Add("Tyler, John");
            oPresidentsList.Add("Polk, James K.");
            oPresidentsList.Add("Taylor, Zachary");
            oPresidentsList.Add("Fillmore, Millard");
            oPresidentsList.Add("Pierce, Franklin");
            oPresidentsList.Add("Buchanan, James");
            oPresidentsList.Add("Lincoln, Abraham");
            oPresidentsList.Add("Johnson, Andrew");
            oPresidentsList.Add("Grant, Ulysses S.");
            oPresidentsList.Add("Hayes, Rutherford B.");
            oPresidentsList.Add("Garfield, James A.");
            oPresidentsList.Add("Arthur, Chester");
            oPresidentsList.Add("Cleveland, Grover");
            oPresidentsList.Add("Harrison, Benjamin");
            oPresidentsList.Add("Cleveland, Grover");
            oPresidentsList.Add("McKinley, William");
            oPresidentsList.Add("Roosevelt, Theodore");
            oPresidentsList.Add("Taft, William Howard");
            oPresidentsList.Add("Wilson, Woodrow");
            oPresidentsList.Add("Harding, Warren G.");
            oPresidentsList.Add("Coolidge, Calvin");
            oPresidentsList.Add("Hoover, Hebert");
            oPresidentsList.Add("Roosevelt, Franklin D.");
            oPresidentsList.Add("Truman, Harry S.");
            oPresidentsList.Add("Eisenhower, Dwight D.");
            oPresidentsList.Add("Kennedy, John F.");
            oPresidentsList.Add("Johnson, Lyndon B.");
            oPresidentsList.Add("Nixon, Richard");
            oPresidentsList.Add("Ford, Gerald");
            oPresidentsList.Add("Carter, Jimmy");
            oPresidentsList.Add("Reagan, Ronald");
            oPresidentsList.Add("Bush, George");
            oPresidentsList.Add("Clinton, Bill");
            oPresidentsList.Add("Bush, George W.");
            oPresidentsList.Add("Obama, Barack");

            //Sort the arraylist [in alphabetical order]
            oPresidentsList.Sort();

            //Display the words in the arraylist, one at a time, until finished
            for (Int32 i = 0; i < oPresidentsList.Count; i++)
            {
                String value = oPresidentsList[i] as string;
                Console.WriteLine(value);
            }

            Pause("\nThe program will now exit.");
        }

        static void Pause(String sMessage)
        {
            Console.WriteLine(sMessage);
            Console.Write("\nPress the enter key to continue. ");
            Console.ReadLine();
            Console.WriteLine();
            
        }
    }
}
