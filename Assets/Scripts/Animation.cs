using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class Animation
    {
        #region Properties
        string _animationId;
        Destination _destination;
        int _endTime;
        int _loopCount;
        string _name;
        int _startTime;
        #endregion

        #region Accessors
        public string animationId { get => _animationId; set => _animationId = value; }
        public Destination destination { get => _destination; set => _destination = value; }
        public int endTime { get => _endTime; set => _endTime = value; }
        public int loopCount { get => _loopCount; set => _loopCount = value; }
        public string name { get => _name; set => _name = value; }
        public int startTime { get => _startTime; set => _startTime = value; }
        #endregion

        #region Constructors
        public Animation()
        {

        }

        public Animation(string _animationIdP, Destination _destinationP, int _endTimeP, int _loopCountP, string _nameP, int _startTimeP)
        {
            animationId = _animationIdP;
            destination = _destinationP;
            endTime = _endTimeP;
            loopCount = _loopCountP;
            name = _nameP;
            startTime = _startTimeP;
        }
        #endregion
    }
}