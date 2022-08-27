using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class Character
    {
        #region Properties
        string _id;
        string _name;
        int _startTime;
        int _endTime;
        string _model;
        List<Element> _elements;
        Origin _origin;
        int _nodeId;
        #endregion

        #region Accessors
        public string id { get => _id; set => _id = value; }
        public string name { get => _name; set => _name = value; }
        public int startTime { get => _startTime; set => _startTime = value; }
        public int endTime { get => _endTime; set => _endTime = value; }
        public string model { get => _model; set => _model = value; }
        public List<Element> elements { get => _elements; set => _elements = value; }
        public Origin origin { get => _origin; set => _origin = value; }
        public int nodeId { get => _nodeId; set => _nodeId = value; }
        #endregion

        #region Constructors
        public Character()
        {

        }
        #endregion

        public void ShowCharacter()
        {
            UnityEngine.Debug.Log(string.Format("id : {0}, name : {1}, startTime : {2}, endTime : {3}, model : {4}", id, name, startTime, endTime, model));
        }
    }
}