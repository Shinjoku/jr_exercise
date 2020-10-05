using System;
using Pathfinder.Model;

// Given a graph and an initial node, make a program that
//  can tell if there's a path that leads to an end node;

/// <summary> 
/// This test is covering the basics of programming, such as:
/// * Data Structures;
/// * Pathfind Algorithms;
/// * 

namespace Pathfinder
{
    class Program
    {
        static void Main(string[] args)
        {
            BFSearch search = new BFSearch();

            // First example of graph
            // Graph graph = new Graph(6);
            // graph.AddNode(0, 1);
            // graph.AddNode(0, 2);
            // graph.AddNode(1, 3);
            // graph.AddNode(2, 1);
            // graph.AddNode(3, 1);
            // graph.AddNode(3, 5);
            // graph.AddNode(4, 0);
            // graph.AddNode(4, 1);
            // graph.AddNode(4, 2);
            // graph.AddNode(5, 5);

            // Second example
            Graph graph = new Graph(7);
            graph.AddNode(0, 1);
            graph.AddNode(0, 2);
            graph.AddNode(0, 6);
            graph.AddNode(1, 0);
            graph.AddNode(1, 2);
            graph.AddNode(2, 0);
            graph.AddNode(2, 1);
            graph.AddNode(2, 3);
            graph.AddNode(2, 4);
            graph.AddNode(2, 6);
            graph.AddNode(3, 2);
            graph.AddNode(3, 4);
            graph.AddNode(4, 2);
            graph.AddNode(4, 3);
            graph.AddNode(4, 5);
            graph.AddNode(5, 2);
            graph.AddNode(5, 4);

            search.BreadthSearch(graph, 0, 5);
        }
    }
}
