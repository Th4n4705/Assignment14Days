using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class Main
    {
        #region Properties 
        List<Node> _nodes;
        #endregion

        #region Accessors
        public List<Node> nodes { get => _nodes; set => _nodes = value; }
        #endregion

        #region Constructors
        public Main()
        {

        }

        public Main(List<Node> _nodesP)
        {
            nodes = _nodesP;
        }
        #endregion
    }
}