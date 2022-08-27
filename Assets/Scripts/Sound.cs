using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OOP;
using System.Diagnostics;

namespace OOP
{
    [System.Serializable]
    public class Sound
    {
        #region Properties
        string _objectName;
        string _objectId;
        string _audioType;
        string _audioUrl;
        bool _loop;
        int _volume;
        int _pitch;
        string _spatialMode;
        int _minDistance;
        int _maxDistance;
        int _startTime;
        int _endTime;
        Origin _origin;
        int _nodeId;
        #endregion

        #region Accessors
        public string objectName { get => _objectName; set => _objectName = value; }
        public string objectId { get => _objectId; set => _objectId = value; }
        public string audioType { get => _audioType; set => _audioType = value; }
        public string audioUrl { get => _audioUrl; set => _audioUrl = value; }
        public bool loop { get => _loop; set => _loop = value; }
        public int volume { get => _volume; set => _volume = value; }
        public int pitch { get => _pitch; set => _pitch = value; }
        public string spatialMode { get => _spatialMode; set => _spatialMode = value; }
        public int minDistance { get => _minDistance; set => _minDistance = value; }
        public int maxDistance { get => _maxDistance; set => _maxDistance = value; }
        public int startTime { get => _startTime; set => _startTime = value; }
        public int endTime { get => _endTime; set => _endTime = value; }
        public int nodeId { get => _nodeId; set => _nodeId = value; }
        #endregion

        #region Constructors
        public Sound()
        {

        }
        #endregion

        #region Methods
        public void ShowSound()
        {
            UnityEngine.Debug.Log(string.Format("objectName : {0}, objectId : {1}, audioType : {2}, audioUrl : {3}, loop : {4}, volume : {5}, pitch : {6}," +
                " spatialMode : {7}, minDistance : {8}, maxDistance : {9}, startTime : {10}, endTime : {11},", objectName, objectId, audioType,
                audioUrl, loop, volume, pitch, spatialMode, minDistance, maxDistance, startTime, endTime));
        }
        #endregion
    }
}
