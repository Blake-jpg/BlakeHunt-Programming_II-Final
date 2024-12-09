using System.Xml.Linq;
//Structure: Rope Data Structure

//rope data structures are used to search through, and change elements on a large amount of text. Arrays do better with small quantities of text, but are difficult to alter, and become slow when handling very large amounts of text. ropes allow you to create and destroy data, where arrays cannot be resized. unlike an array a rope structure uses a binary tree to find its elements which lowers the cost of the search.

//NOT IMPLIMENTED:
//I wanted to have the word you are editing to be marked in some way, this would require re working the PrintText method to notice a new user input, but I am out of time.
//given I were to do this project again I would probably take the user input in as sentences, then break those down into words by finding space characters.
//People were using Queue to create binary trees on stack overflow for slightly simpler integer containing binary trees. this is more difficult with strings

//PROGRAM INCOMPLETE: 
//Attchieved                                            Incomplete
//gathered user input                                   ran out of time to complete editing functionality
// converted that into a tree                           unsure how to convert queue<Node> into a printable format
//                                                      broke print functionality halfway through trying to make                                                       binary tree

namespace BlakeHunt_Programming_II_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool createMode = true;

            List<string> userList = new List<string>();
            int i = 0;

            UpdateScreen(userList);

            string newWord = Convert.ToString(Console.ReadLine());

            while (createMode)
            {
                if (newWord == "!done")
                {
                    createMode = false;
                }
                else
                {
                    userList.Add(newWord);
                    Console.Clear();
                    UpdateScreen(userList);
                    newWord = Convert.ToString(Console.ReadLine());
                    i++;
                }
            }

            while (!createMode)
            {
                Queue<tNode> bigTree = RopeTools.CreateTree(userList);

                RopeTools.PrintText(bigTree);

                //EditMode(tree);
            }
        }

        //I probably should've used the winform template
        public static void UpdateScreen(List<string> words)
        {
            Console.Clear();

            Console.WriteLine("Type '!done' to start the edit mode");
            Console.WriteLine("~~~~~~Write Mode~~~~~~");
            foreach (string item in words)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
        }
        public static void EditMode(tNode goodTree)
        {
            tNode tree = new tNode();
            tree = goodTree;

            Console.Clear();

            Console.WriteLine("~~~~~~Edit Mode~~~~~~");

            //RopeTools.PrintText(tree);

            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");

            Console.ReadLine();
        }
    }
}
