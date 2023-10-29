using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WPFSweeper
{
    public partial class Game
    {
        public partial class Grid
        {
            private static List<GraphNode> nodes = new();
            private class GraphNode
            {
                /// <summary>
                /// The cell that this node contains
                /// </summary>
                public Cell Item { get; private set; }
                /// <summary>
                /// The cell's neighbors
                /// </summary>
                public List<GraphNode> Neighbors { get; private set; }
                /// <summary>
                /// Whether the cell has been visited
                /// </summary>
                public bool IsVisited { get; private set; }
                /// <summary>
                /// Initialize the GraphNode with the node wrapped inside
                /// </summary>
                /// <param name="item">The item to be wrapped inside</param>
                /// <param name="neighbors">The list of neighbors of the cell</param>
                public GraphNode(Cell item, List<GraphNode>? neighbors = null) 
                {                    
                    this.Item = item;
                    if (neighbors != null) this.Neighbors = neighbors;
                    else this.Neighbors = new();
                    nodes.Add(this);
                }
                /// <summary>
                /// Get all the neighbors of the cell. The number of neighbors of each cell varies from 2 to 4
                /// </summary>
                private void GetAllNeighbors()
                {
                    int x = this.Item.X;
                    int y = this.Item.Y;
                    NeighborCellsAction(x, y,
                        (x, y) => 
                        { //if the graph node has already been created, assign that as the neighbor, otherwise, create a neighbor.
                            foreach(GraphNode node in nodes)
                            {
                                if (node.Item.X == x && node.Item.Y == y)
                                    Neighbors.Add(node);
                                return;
                            }
                            GraphNode toAdd = new(grid.CellGrid[x][y]);
                            Neighbors.Add(toAdd);
                        }, 
                        (x, y) => 
                        { //filter out the cell itself and diagonal neighbors
                            return (x != y) && (x != -y);
                        });
                }
            }
        }
    }
}
