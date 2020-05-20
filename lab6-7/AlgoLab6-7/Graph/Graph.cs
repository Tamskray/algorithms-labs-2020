using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Graph
    {
        List<Vertex> Vertexes = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();

        public int VertexCount => Vertexes.Count;
        public int EdgesCount => Edges.Count;

        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }

        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }

        public void AddEdge(Vertex from, Vertex to, int weight)
        {
            var edge = new Edge(from, to, weight);
            Edges.Add(edge);
        }
        public int[,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Vertexes.Count];
            
            foreach(var edge in Edges)
            {
                var row = edge.From.Number;
                var column = edge.To.Number;

                matrix[row, column] = edge.Weight;
            }
            return matrix;
        }

        public List<Vertex> GetVertexLists(Vertex vertex)
        {
            var result = new List<Vertex>();
            foreach(var edge in Edges)
            {
                if(edge.From == vertex)
                {
                    result.Add(edge.To);
                }
            }
            return result;
        }
    }
}
