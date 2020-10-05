using System;
using System.Collections.Generic;

namespace Pathfinder.Model
{
    public class Graph
    {
        public int NumberOfVertices { get; set; }
        public List<int>[] AdjacentNodes { get; set; }

        public Graph(int numberOfVertices)
        {
            NumberOfVertices = numberOfVertices;

            AdjacentNodes = new List<int>[NumberOfVertices];
            for (int i = 0; i < AdjacentNodes.Length; i++)
            {
                AdjacentNodes[i] = new List<int>();
            }
        }

        public void AddNode(int vertice, int weight)
        {
            AdjacentNodes[vertice].Add(weight);
        }
    }
}