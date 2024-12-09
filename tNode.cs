using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlakeHunt_Programming_II_Final
{
    //TreePart is a weird name, change later
    public class tNode
    {
        //parent node
        public tNode pnode;
        //child nodes / next nodes
        public tNode lnode;
        public tNode rnode;
        //node data
        public List<string> word;
        //depth of the parent node
        public int depth;

        public tNode()
        {
            this.lnode = null;
            this.rnode = null;
            this.pnode = null;
            this.word = new List<string>();
            this.depth = 0;
        }
    }
}
