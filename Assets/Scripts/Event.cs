using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class Event
    {
        #region Properties 
        int _desiredEventValue;
        string _eventType;
        #endregion

        #region Accessors
        public int desiredEventValue { get => _desiredEventValue; set => _desiredEventValue = value; }
        public string eventType { get => _eventType; set => _eventType = value; }
        #endregion

        #region Constructors
        public Event()
        {

        }

        public Event(int _desiredEventValueP, string _eventTypeP)
        {
            desiredEventValue = _desiredEventValue;
            eventType = _eventTypeP;
        }
        #endregion
    }
}