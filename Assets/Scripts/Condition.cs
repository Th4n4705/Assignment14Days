using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class Condition
    {
        #region Properties 
        string _conditionType;
        Event _event;
        int _nodeId;
        #endregion

        #region Accessors
        public string conditionType { get => _conditionType; set => _conditionType = value; }
        public Event @event { get => _event; set => _event = value; }
        public int nodeId { get => _nodeId; set => _nodeId = value; }
        #endregion

        #region Constructors
        public Condition()
        {

        }

        public Condition(string _conditionTypeP, Event _eventP)
        {
            conditionType = _conditionTypeP;
            @event = _eventP;
        }
        #endregion
    }
}