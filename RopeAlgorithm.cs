using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlakeHunt_Programming_II_Final
{
    public class RopeTools
    {
        public static Queue<tNode> CreateTree(List<string> str)
        {
            Queue<tNode> path = new Queue<tNode>();

            //unused
            int wordcount = str.Count;
            double estdepth = Math.Ceiling(wordcount % 2.0);
            for (int e = wordcount; e > -1; e++)
            {
                estdepth = estdepth + 1;
            }

            if (str == null)
            {
                //this never triggers
                Console.WriteLine("CreateTree gets null list");
            }

            //create all leaf nodes
            for (int n = 0; n < wordcount; n++)
            {
                tNode tmp = new tNode();
                string w = str[n];
                tmp = CreateNode(tmp, null, w);
                path.Enqueue(tmp);
            }

            //make tree
            while (path.Count > 1)
            {
                tNode left = path.Dequeue();
                tNode right = path.Dequeue();
                tNode par = new tNode();

                par.lnode = left;
                par.rnode = right;

                path.Enqueue(par);
            }

            return path;
        }

        static tNode CreateNode(tNode node, tNode par, string word)
        {
            tNode tmp = new tNode();
            tmp.lnode = tmp.rnode = null;
            tmp.pnode = par;
            node = tmp;

            tmp.word.Add(word);

            return node;
        }

        public static void PrintText(Queue<tNode> t)
        {

        }

        public static tNode JoinTrees(tNode parTree, tNode tree1, tNode tree2, int parentdepth)
        {
            tNode tmp = new tNode();
            tmp.lnode = tree1;
            tmp.rnode = tree2;

            tree1.rnode = tmp;
            tree2.rnode = tmp;

            tmp.depth = parentdepth;

            tmp.word = null;
            parTree = tmp;

            return parTree;
        }
    }
}
