using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(200, 60);

            var graph = new Graph();

            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(7);
            var v8 = new Vertex(8);
            var v9 = new Vertex(9);
            var v10 = new Vertex(10);
            var v11 = new Vertex(11);
            var v12 = new Vertex(12);
            var v13 = new Vertex(13);
            var v14 = new Vertex(14);
            var v15 = new Vertex(15);
            var v16 = new Vertex(16);
            var v17 = new Vertex(17);
            var v18 = new Vertex(18);
            var v19 = new Vertex(19);
            var v20 = new Vertex(20);

            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);
            graph.AddVertex(v7);
            graph.AddVertex(v8);
            graph.AddVertex(v9);
            graph.AddVertex(v10);
            graph.AddVertex(v11);
            graph.AddVertex(v12);
            graph.AddVertex(v13);
            graph.AddVertex(v14);
            graph.AddVertex(v15);
            graph.AddVertex(v16);
            graph.AddVertex(v17);
            graph.AddVertex(v18);
            graph.AddVertex(v19);
            graph.AddVertex(v20);

            graph.AddEdge(v1, v2, 135);
            graph.AddEdge(v1, v3, 78);
            graph.AddEdge(v1, v4, 128);
            graph.AddEdge(v2, v5, 80);
            graph.AddEdge(v2, v6, 38);
            graph.AddEdge(v2, v7, 115);
            graph.AddEdge(v3, v8, 115);
            graph.AddEdge(v3, v9, 146);
            graph.AddEdge(v3, v10, 181);
            graph.AddEdge(v4, v11, 175);
            graph.AddEdge(v4, v12, 109);
            graph.AddEdge(v5, v13, 100);
            graph.AddEdge(v6, v14, 73);
            graph.AddEdge(v9, v15, 105);
            graph.AddEdge(v10, v16, 130);
            graph.AddEdge(v13, v17, 68);
            graph.AddEdge(v14, v18, 110);
            graph.AddEdge(v18, v19, 104);
            GetMatrix(graph);

            Console.WriteLine();
            Console.WriteLine("Возможные пути с вершин:");
            GetVertex(graph, v1);
            GetVertex(graph, v2);
            GetVertex(graph, v3);
            GetVertex(graph, v4);
            GetVertex(graph, v5);
            GetVertex(graph, v6);
            GetVertex(graph, v7);
            GetVertex(graph, v8);
            GetVertex(graph, v9);
            GetVertex(graph, v10);
            GetVertex(graph, v11);
            GetVertex(graph, v12);
            GetVertex(graph, v13);
            GetVertex(graph, v14);
            GetVertex(graph, v15);
            GetVertex(graph, v16);
            GetVertex(graph, v17);
            GetVertex(graph, v18);
            GetVertex(graph, v19);
            Console.ReadLine();
        }
        private static void GetMatrix(Graph graph)
        {
            Console.WriteLine("Матрица смежности:\n");
            var matrix = graph.GetMatrix();

            Console.Write("");
            for (int i = 0; i < graph.VertexCount - 1; i++)
            {
                Console.Write($"     {i + 1:D2}  ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('_', 172));
            for (int i = 1; i < graph.VertexCount; i++)
            {
                Console.Write($"{i:D2}");
                for (int j = 1; j < graph.VertexCount; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Console.Write($" |  {matrix[i, j]}  | ");
                    }
                    if (matrix[i, j] >= 100 && matrix[i, j] <= 999)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($" | {matrix[i, j]} | ");
                        Console.ResetColor();
                    }
                    if (matrix[i, j] <= 99 && matrix[i, j] >= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write($" | {matrix[i, j]}  | ");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('_', 172));
        }

        private static void GetVertex(Graph graph, Vertex vertex)
        {
            Console.Write(vertex.Number + ":");
            foreach (var v in graph.GetVertexLists(vertex))
            {
                Console.Write(v.Number + " ");
            }
            Console.WriteLine();
        }
    }
}
