using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class Node
    {
        private int Gcost;
        private int Hcost;
        private int Fcost;
        private string Name;
        private bool IsStartingNode;
        private Node Neighbour;

        public Node(Node Neighbour, string Name)
        {
            this.Neighbour = Neighbour;
            this.Name = Name;
            this.IsStartingNode = false;
        }

        public void SetStartingNode()
        {
            this.IsStartingNode = true;
            this.Gcost = 0;
        }

        public void CalcGcost()
        {
            this.Gcost = this.Neighbour.GetGcost() + 10;
        }
        public int GetGcost()
        {
            return this.Gcost;
        }
    }
}
