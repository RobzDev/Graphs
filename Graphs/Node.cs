using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Graphs
{
    internal class Node
    {
        public string Name { get; set; }
        public List<Edge> Neighbors { get; set; }

        public Node(string name)
        {
            Name = name;
            Neighbors = new List<Edge>();
        }
    }
}
