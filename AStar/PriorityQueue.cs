using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class PriorityQueue
    {
        Dictionary<Node, int> Queue;
        private int qSize;
        private int index;

        public PriorityQueue(int qSize)
        {
            this.qSize = qSize;
            this.Queue = new Object[this.qSize,1];
            this.index = -1;
        }

        public void Insert(Node n)
        {
            Queue.Add(n, n.GetFcost());

        }

        public Object[,] Delete()
        {
            return this.Queue[this.Queue.Length - 1, 0];
        }

    }
}
