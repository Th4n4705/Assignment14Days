using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class Element
    {
        #region Properties
        string _elementType;
        Animation _animation;
        string _id;
        #endregion

        #region Accessors
        public string elementType { get => _elementType; set => _elementType = value; }
        public Animation animation { get => _animation; set => _animation = value; }
        public string id { get => _id; set => _id = value; }
        #endregion

        #region Constructors
        public Element()
        {

        }

        public Element(string _elementTypeP, Animation _animationP, string _idP)
        {
            elementType = _elementTypeP;
            animation = _animationP;
            id = _idP;
        }
        #endregion
    }
}