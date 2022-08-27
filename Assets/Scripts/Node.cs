using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class Node
    {
        #region Properties 
        string _name;
        int _nodeId;
        string _nodeType;
        int _nextNodeId;
        int _startTime;
        int _endTime;
        Origin _origin;
        List<NodeElement> _nodeElements;
        List<Condition> _conditions;
        #endregion

        #region Accessors
        public string name { get => _name; set => _name = value; }
        public int nodeId { get => _nodeId; set => _nodeId = value; }
        public string nodeType { get => _nodeType; set => _nodeType = value; }
        public int nextNodeID { get => _nextNodeId; set => _nextNodeId = value; }
        public int startTime { get => _startTime; set => _startTime = value; }
        public int endTime { get => _endTime; set => _endTime = value; }
        public Origin origin { get => _origin; set => _origin = value; }
        public List<NodeElement> nodeElements { get => _nodeElements; set => _nodeElements = value; }
        public List<Condition> conditions { get => _conditions; set => _conditions = value; }
        #endregion

        #region Constructors
        public Node()
        {

        }

        public Node(string _nameP, int _nodeIdP, string _nodeTypeP, int _nextNodeIdP, int _startTimeP, int _endTimeP, Origin _originP, List<NodeElement> _nodeElementsP, List<Condition> _conditionsP)
        {
            name = _nameP;
            nodeId = _nodeIdP;
            nodeType = _nodeTypeP;
            nextNodeID = _nextNodeIdP;
            startTime = _startTimeP;
            endTime = _endTimeP;
            origin = _originP;
            nodeElements = _nodeElementsP;
            conditions = _conditionsP;
        }
        #endregion
        
        #region Methods
        public void ShowNodes()
        {
            if (nodeType == "SNode")
                UnityEngine.Debug.Log(string.Format("name : {0}, NodeId : {1}, NodType : {2}, NextNodeID : {3}, StartTime : {4}, endTime : {5}, Position : [{6},{7},{8}], Rotation : [{9},{10},{11}],",
                    name, nodeId, nodeType, nextNodeID, startTime, endTime, origin.position[0], origin.position[1], origin.position[2], origin.rotation[0], origin.rotation[1], origin.rotation[2]));
            else
                UnityEngine.Debug.Log(string.Format("name : {0}, NodeId : {1}, NodType : {2}, NextNodeID : {3}", name, nodeId, nodeType, nextNodeID));

        }
        #endregion
    }
}