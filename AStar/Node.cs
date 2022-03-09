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

        public Node(string Name)
        {
            this.Name = Name;
            this.IsStartingNode = false;

            
        }
        
        public void SetNeighbour(Node neighbour)
        {
            this.Neighbour = neighbour;
            this.Gcost = this.Neighbour.GetGcost() + 10;
        }

        public void SetStartingNode()
        {
            this.IsStartingNode = true;
            this.Gcost = 0;
        }

        public int GetGcost()
        {
            return this.Gcost;
        }

        public void SetHcost(int Hcost)
        {
            this.Hcost = Hcost;
        }

        public void SetFcost()
        {
            this.Fcost = this.Hcost + this.Gcost;
        }

        public int GetFcost()
        {
            return this.Fcost;
        }
    }
}
