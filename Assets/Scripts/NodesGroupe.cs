using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using OOP;

namespace OOP
{
    [System.Serializable]
    public class NodesGroupe
    {
        #region Properties 
        string _mainName;
        Main _main;
        #endregion

        #region Accessors
        public string mainName { get => _mainName; set => _mainName = value; }
        public Main main { get => _main; set => _main = value; }
        #endregion

        #region Constructors
        public NodesGroupe()
        {

        }

        public NodesGroupe(string _mainNameP, Main _mainP)
        {
            mainName = _mainNameP;
            main = _mainP;
        }
        #endregion
        /*
        #region Methodes
        #region Editor
        [CustomEditor(typeof(NodesGroupe))]
        public class NodesGroupeEditor : Editor
        {
            public override void OnInspectorGUI()
            {
                base.OnInspectorGUI();

                EditorGUILayout.LabelField("Details :");
                mainName = EditorGUILayout.TextField(mainName);
            }
        }
        #endregion
        #endregion*/
        /*
#region Methods
        // create the unique id
        public string IdGenerator()
        {
            //the idea here is to use the time when we take an instance
            //so the id is the year /day of the year/hour/ minute/ secondes
            string uniqueId = DateTime.Now.Year.ToString()
                + IdPartsChecker(DateTime.Now.DayOfYear.ToString(), 3)
                + IdPartsChecker(DateTime.Now.Hour.ToString(), 2)
                + IdPartsChecker(DateTime.Now.Minute.ToString(), 2)
                + IdPartsChecker(DateTime.Now.Second.ToString(), 2);
            return uniqueId;
        }

        //check every portion of Id if it's length is one
        //just to make sure that the id got every time the same number of character
        public string IdPartsChecker(string idSlice, int SliceLenght)
        {
            string correctFormat = "";
            if (SliceLenght == idSlice.Length)
                return idSlice;
            else if (SliceLenght - idSlice.Length == 1)
                correctFormat = "0" + idSlice;
            else if (SliceLenght - idSlice.Length == 2)
                correctFormat = "00" + idSlice;
            return correctFormat;
        }

        //Get shape Data
        public string ShowShape()
        {
            string shape = Id +
                 "    " + Width +
                 "         " + Height +
                 "         " + SidesAmount +
                 "              [" + Position[0] + ", " + Position[1] + ", " + Position[2] + "] " +
                 "   " + Scale +
                 "          [" + Rotation[0] + ", " + Rotation[1] + ", " + Rotation[2] + "] ";

            return shape;
        }
        //search shape Data
        public bool SearchShape(string idShape)
        {
            if (idShape == Id)
                return true;
            return false;
        }

        public void EditShapeObject(float[] position, float scale, float[] rotation)
        {
            Position = position;
            Scale = scale;
            Rotation = rotation;
        }
#endregion*/
    }
}