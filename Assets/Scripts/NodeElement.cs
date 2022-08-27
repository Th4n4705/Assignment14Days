using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class NodeElement
    {
        #region Properties 
        string _elementType;
        Sound _sound;
        Character _character;
        #endregion

        #region Accessors
        public string elementType { get => _elementType; set => _elementType = value; }
        public Sound sound { get => _sound; set => _sound = value; }
        public Character character { get => _character; set => _character = value; }
        #endregion

        #region Constructors
        public NodeElement()
        {

        }
        #endregion
    }
}