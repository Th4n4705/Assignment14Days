using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class Origin
    {
        #region Properties 
        List<int> _position;
        List<int> _rotation;
        #endregion

        #region Accessors
        public List<int> position { get => _position; set => _position = value; }
        public List<int> rotation { get => _rotation; set => _rotation = value; }
        #endregion

        #region Constructors
        public Origin()
        {

        }

        public Origin(List<int> _positionP, List<int> _rotationP)
        {
            position = _positionP;
            rotation = _rotationP;
        }
        #endregion
    }
}