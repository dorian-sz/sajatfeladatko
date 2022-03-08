using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class Node
    {
        int Gcost;
        int Hcost;
        int Fcost;
        Node Neighbour;
    }
}
