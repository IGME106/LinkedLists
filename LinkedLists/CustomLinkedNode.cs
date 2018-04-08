using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice exersize 14
/// Class Description   : Custom Linked Node class
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : March 26, 2018
/// Filename            : CustomLinkedNode.cs
/// </summary>

namespace LinkedLists
{
    class CustomLinkedNode
    {
        public string Data { get; set; }
        public CustomLinkedNode Next { get; set; }

        public CustomLinkedNode(string inputData)
        {
            this.Data = inputData;
            this.Next = null;
        }

    }
}
