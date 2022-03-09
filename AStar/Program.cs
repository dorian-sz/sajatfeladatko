using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class Program
    {
        static void Main(string[] args)
        {
            Node A = new Node(B, "A");
            Node B = new Node(A, "B");

            A.SetStartingNode();
            Console.WriteLine(B.GetGcost());
        }
    }
}
