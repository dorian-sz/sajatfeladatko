using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStar
{
    class PriorityQueue
    {
        private Object[,] Queue;
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
            if (this.index != this.qSize)
	        {
                this.index++;
                this.Queue[this.index, 0] = n;
                this.Queue[this.index, 1] =  n.GetFcost();
	        }
            else
            {
                Console.WriteLine("Queue is full.");
            }

        }

        public Object[] Delete()
        {
            return this.Queue[this.Queue.Length - 1, 0];
        }

    }
}
