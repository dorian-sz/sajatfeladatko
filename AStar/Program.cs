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
            //Create nodes and set a starting node and its their neighbours.
            PriorityQueue queue = new PriorityQueue(6);

            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node F = new Node("F");

            A.SetStartingNode();
            B.SetNeighbour(A);
            C.SetNeighbour(A);
            D.SetNeighbour(B);
            E.SetNeighbour(D);
            F.SetNeighbour(F);

            queue.Insert(A);
            Console.WriteLine(queue.Delete());

            Console.ReadKey();
        }
    }
}
