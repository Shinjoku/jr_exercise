using System;
using System.Collections.Generic;
using System.Linq;
using Pathfinder.Model;

namespace Pathfinder
{
    public class BFSearch
    {
        public void BreadthSearch(Graph graph, int start, int end)
        {
            Queue<int> queue = new Queue<int>();
            bool[] visitedNodes = new bool[graph.NumberOfVertices];
            int current;

            for (int i = 0; i < graph.NumberOfVertices; i++)
                visitedNodes[i] = false;

            queue.Enqueue(start);
            while (queue.Any())
            {
                current = queue.Dequeue();
                if (current == end)
                {
                    Console.WriteLine("There's a path.");
                    return;
                }
                else
                {
                    foreach (var node in graph.AdjacentNodes[current])
                    {
                        if (!visitedNodes[node]) {
                            visitedNodes[node] = true;
                            queue.Enqueue(node);
                            Console.Write(node + " ");
                        }
                    }
                }
            }

            Console.WriteLine($"There's no path for this target beginning from the node {start}.");
        }
    }
}