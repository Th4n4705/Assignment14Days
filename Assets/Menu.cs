using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using OOP;
using System.Diagnostics;

public enum MenuChoices { Node, Sound, Character, Condition }
public enum NodeType { SNode, LNode }

public class Menu : MonoBehaviour
{
    #region JsonParser
    // Start is called before the first frame update
    /*  void Start()
      {
          string filePath = @"Assets/Data/main.Json";
          if (!File.Exists(filePath))
              return;
          string jsonString = File.ReadAllText(filePath);
          Root myDeserializedClass = new Root();
          myDeserializedClass = JsonUtility.FromJson<Root>(jsonString);

          Debug.Log("-------------------");
          Debug.Log(myDeserializedClass.mainName);
          Debug.Log("-------------------");
          ShowAllNode(myDeserializedClass);
          // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
          //JsonConvert.DeserializeObject<List<Root>>(jsonString);
      }*/
    #endregion

    [Header("MenU")]
    [SerializeField] MenuChoices menuChoices;
    public static NodesGroupe nodesGroupe = new NodesGroupe();
    public static Node node = new Node();
    public static Main main = new Main();
    public static Origin origin = new Origin();
    public static Condition condition = new Condition();
    public static Character character = new Character();
    public static Sound sound = new Sound();
    public static OOP.Event evnt = new OOP.Event();
    public static List<Node> nodeList = new List<Node>();
    public static List<Condition> conditionList = new List<Condition>();
    public static List<Character> characterList = new List<Character>();
    public static List<Sound> soundList = new List<Sound>();
    public static List<OOP.Event> eventList = new List<OOP.Event>();

    public static int positionX;
    public static int positionY;
    public static int positionZ;
    public static int rotationX;
    public static int rotationY;
    public static int rotationZ;

    #region Editor
    [CustomEditor(typeof(Menu))]
    public class MenuEditor : Editor
    {
        public NodeType nodeType;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            Menu menu = (Menu)target;

            EditorGUILayout.LabelField("Main Name :");
            nodesGroupe.mainName = EditorGUILayout.TextField(nodesGroupe.mainName);
            EditorGUILayout.Space(10);


            #region Node CHoice
            if (menu.menuChoices == MenuChoices.Node)
            {
                EditorGUILayout.LabelField("Node Id :");
                node.nodeId = EditorGUILayout.IntField(node.nodeId);

                EditorGUILayout.LabelField("Node Name :");
                node.name = EditorGUILayout.TextField(node.name);

                EditorGUILayout.LabelField("Next Node Id :");
                node.nextNodeID = EditorGUILayout.IntField(node.nextNodeID);

                nodeType = (NodeType)EditorGUILayout.EnumPopup("Node Type:", nodeType);
                node.nodeType = nodeType.ToString();
               // NodeTypeEnumPopupSwitch(nodeType);
                if (nodeType == NodeType.SNode)
                {
                    EditorGUILayout.LabelField("Start Time :");
                    node.startTime = EditorGUILayout.IntField(node.startTime);

                    EditorGUILayout.LabelField("EndTime :");
                    node.endTime = EditorGUILayout.IntField(node.endTime);

                    EditorGUILayout.Space();
                    //position
                    EditorGUILayout.LabelField("Position :");
                    EditorGUILayout.BeginHorizontal();

                    EditorGUILayout.LabelField("X :", GUILayout.MaxWidth(50));
                    positionX = EditorGUILayout.IntField(positionX);
                    EditorGUILayout.LabelField("Y :", GUILayout.MaxWidth(50));
                    positionY = EditorGUILayout.IntField(positionY);
                    EditorGUILayout.LabelField("Z :", GUILayout.MaxWidth(50));
                    positionZ = EditorGUILayout.IntField(positionZ);

                    EditorGUILayout.EndHorizontal();

                    EditorGUILayout.Space();
                    //rotation
                    EditorGUILayout.LabelField("Rotation :");
                    EditorGUILayout.BeginHorizontal();

                    EditorGUILayout.LabelField("X :", GUILayout.MaxWidth(50));
                    rotationX = EditorGUILayout.IntField(rotationX);
                    EditorGUILayout.LabelField("Y :", GUILayout.MaxWidth(50));
                    rotationY = EditorGUILayout.IntField(rotationY);
                    EditorGUILayout.LabelField("Z :", GUILayout.MaxWidth(50));
                    rotationZ = EditorGUILayout.IntField(rotationZ);


                    EditorGUILayout.EndHorizontal();
                }
                if (GUILayout.Button("Add Node"))
                {
                    Node nodeToList = new Node();
                    if (nodeType == NodeType.SNode)
                    {
                        List<int> pos = new List<int>();
                        List<int> rot = new List<int>();

                        pos.Add(positionX);
                        pos.Add(positionY);
                        pos.Add(positionZ);
                        origin.position = pos;

                        rot.Add(rotationX);
                        rot.Add(rotationY);
                        rot.Add(rotationZ);
                        origin.position = rot;

                        nodeToList.origin = origin;
                        nodeToList.startTime = node.startTime;
                        nodeToList.endTime = node.endTime;
                    }
                    nodeToList.nodeId = node.nodeId;
                    nodeToList.name = node.name;
                    nodeToList.nextNodeID = node.nextNodeID;
                    nodeToList.nodeType = node.nodeType;
                    nodeList.Add(nodeToList);
                    print("\n <color=#00FF00> Node Added Successfully! </color>" + node.nodeId.ToString());
                }
                if (GUILayout.Button("Edit Node"))
                {
                }
                if (GUILayout.Button("Delete Node"))
                {
                    RemoveNode(node.nodeId, nodeList);
                }
                if (GUILayout.Button("List Nodes"))
                {
                    ListAllNodesWithSpecificType(nodeList, nodeType);
                }
            }
            #endregion

            #region Condition  CHoice
            if (menu.menuChoices == MenuChoices.Condition)
            {
                EditorGUILayout.LabelField("ADD EVENT :");

                EditorGUILayout.Space();

                EditorGUILayout.LabelField("Event Id :");
                evnt.desiredEventValue = EditorGUILayout.IntField(evnt.desiredEventValue);

                EditorGUILayout.LabelField("Event Type :");
                evnt.eventType = EditorGUILayout.TextField(evnt.eventType);


                if (GUILayout.Button("Add Event"))
                {
                    OOP.Event newEvent = new OOP.Event();
                    newEvent.eventType = evnt.eventType;
                    newEvent.desiredEventValue = evnt.desiredEventValue;

                    eventList.Add(newEvent);
                    print("List Of Event :");
                    print("desiredEventValue :          eventType :");
                    foreach (OOP.Event eventItem in eventList)
                        print(eventItem.desiredEventValue.ToString() + "          " + eventItem.eventType);
                }
                EditorGUILayout.Space();

                int eventIdToCheck = 0;
                EditorGUILayout.LabelField("Event Id :");
                eventIdToCheck = EditorGUILayout.IntField(eventIdToCheck);

                EditorGUILayout.LabelField("Node Id :");
                condition.nodeId = EditorGUILayout.IntField(condition.nodeId);

                EditorGUILayout.LabelField("condition Type :");
                condition.conditionType = EditorGUILayout.TextField(condition.conditionType);
                if (GUILayout.Button("Add Condition"))
                {
                    OOP.Condition ConditionItem = new OOP.Condition();
                    ConditionItem.@event = RetrieveEvent(eventIdToCheck, eventList);
                    ConditionItem.conditionType = condition.conditionType;
                    ConditionItem.nodeId = condition.nodeId;

                    conditionList.Add(ConditionItem);
                }
                if (GUILayout.Button("Edit Condition"))
                {
                }
                if (GUILayout.Button("Delete Condition"))
                {
                    RemoveCondition(condition.conditionType, conditionList);
                }
                if (GUILayout.Button("List Conditions"))
                {
                    ListConditions(conditionList);
                }
            }
            #endregion

            #region Character  CHoice
            if (menu.menuChoices == MenuChoices.Character)
            {
                EditorGUILayout.LabelField("Character Id :");
                character.id = EditorGUILayout.TextField(character.id);

                EditorGUILayout.LabelField("Character Name :");
                character.name = EditorGUILayout.TextField(character.name);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Start Time :", GUILayout.MaxWidth(50));
                character.startTime = EditorGUILayout.IntField(character.startTime);
                EditorGUILayout.LabelField("End Time :", GUILayout.MaxWidth(50));
                character.endTime = EditorGUILayout.IntField(character.endTime);
                EditorGUILayout.EndHorizontal();

                EditorGUILayout.LabelField("Character Model :");
                character.model = EditorGUILayout.TextField(character.model);

                if (GUILayout.Button("Add Character"))
                {
                    Character characterItem = new Character();

                    characterItem.id = character.id;

                    characterItem.name = character.name;

                    characterItem.startTime = character.startTime;

                    characterItem.endTime = character.endTime;

                    characterItem.model = character.model;

                    characterList.Add(characterItem);
                }
                if (GUILayout.Button("Edit Character"))
                {
                }
                if (GUILayout.Button("Delete Character"))
                {
                    RemoveCharacter(character.id, characterList);
                }
                if (GUILayout.Button("List Characters"))
                {
                    ListCharacters(characterList);
                }
            }
            #endregion

            #region Sound  CHoice
            if (menu.menuChoices == MenuChoices.Sound)
            {
                EditorGUILayout.LabelField("Sound Id :");
                sound.objectId = EditorGUILayout.TextField(sound.objectId);

                EditorGUILayout.LabelField("Sound Name :");
                sound.objectName = EditorGUILayout.TextField(sound.objectName);

                EditorGUILayout.LabelField("Audio Type :");
                sound.audioType = EditorGUILayout.TextField(sound.audioType);

                EditorGUILayout.LabelField("Audio Url :");
                sound.audioUrl = EditorGUILayout.TextField(sound.audioUrl);

                EditorGUILayout.LabelField("Loop :");
                sound.loop = EditorGUILayout.Toggle(sound.loop);

                EditorGUILayout.LabelField("Volum :");
                sound.volume = EditorGUILayout.IntSlider(sound.volume, 1, 10);

                EditorGUILayout.LabelField("Pitch :");
                sound.pitch = EditorGUILayout.IntField(sound.pitch);

                EditorGUILayout.LabelField("Spatial Mode :");
                sound.spatialMode = EditorGUILayout.TextField(sound.spatialMode);

                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Min Distance :", GUILayout.MaxWidth(50));
                sound.minDistance = EditorGUILayout.IntField(sound.minDistance);
                EditorGUILayout.LabelField("Max Distance :", GUILayout.MaxWidth(50));
                sound.maxDistance = EditorGUILayout.IntField(sound.maxDistance);
                EditorGUILayout.EndHorizontal();
                
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.LabelField("Start Time :", GUILayout.MaxWidth(50));
                sound.startTime = EditorGUILayout.IntField(sound.startTime);
                EditorGUILayout.LabelField("End Time :", GUILayout.MaxWidth(50));
                sound.endTime = EditorGUILayout.IntField(sound.endTime);
                EditorGUILayout.EndHorizontal();

               /* if (nodeList.Count > 0)
                    EditorGUILayout.Popup(":", nodeList.ToArray());*/
                if (GUILayout.Button("Add Sound"))
                {
                    Sound soundItem = new Sound();

                    soundItem.objectId = sound.objectId;

                    soundItem.objectName = sound.objectName;

                    soundItem.audioType = sound.audioType;

                    soundItem.audioUrl = sound.audioUrl;

                    soundItem.loop = sound.loop;

                    soundItem.volume = sound.volume;

                    soundItem.pitch = sound.pitch;

                    soundItem.spatialMode = sound.spatialMode;

                    soundItem.minDistance = sound.minDistance;

                    soundItem.maxDistance = sound.maxDistance;

                    soundItem.startTime = sound.startTime;

                    soundItem.endTime = sound.endTime;

                    soundList.Add(soundItem);
                }
                if (GUILayout.Button("Edit Sound"))
                {
                }
                if (GUILayout.Button("Delete Sound"))
                {
                    RemoveSound(sound.objectId, soundList);
                }
                if (GUILayout.Button("List Sounds"))
                {
                    ListSounds(soundList);
                }
            }
            #endregion



        }
    }
    #endregion

    #region Nodes Methodes
    public static void ListAllNodesWithSpecificType(List<Node> nodeList, NodeType nodeType)
    {
        if (nodeType == NodeType.SNode)
        {
            print($"\n<color=#00FF00> Id:     Name:     Node Type:     start Time:     End Time:     Position:     Rotation:</color>");
            foreach (Node nodeItem in nodeList)
            {
                if (node.nodeType == nodeType.ToString())
                {
                    print("\n" + nodeItem.nodeId.ToString() + "     " + nodeItem.name + "     " + nodeItem.nodeType.ToString() + "     "
                        + nodeItem.startTime.ToString() + "     " + nodeItem.endTime.ToString()
                        + "     [" + nodeItem.origin.position[0].ToString() + ", " + nodeItem.origin.position[1].ToString() + ", "
                        + nodeItem.origin.position[2].ToString() + " ]     " + " [" + nodeItem.origin.rotation[0].ToString() + ", "
                        + nodeItem.origin.rotation[1].ToString() + ", " + nodeItem.origin.rotation[2].ToString() + " ] ");
                }
            }
        }
        else if (nodeType == NodeType.LNode)
        {
            print($"<color=#00FF00>\n Id:     Name:     Node Type: </color>");
            foreach (Node nodeItem in nodeList)
            {
                if (nodeItem.nodeType == nodeType.ToString())
                {
                    print("\n" + nodeItem.nodeId.ToString() + "     " + nodeItem.name + "     " + nodeItem.nodeType.ToString());
                }
            }
        }


    }

    public static void RemoveNode(int id, List<OOP.Node> list)
    {
        foreach (Node nodeItem in nodeList)
        {
            if (nodeItem.nodeId == id)
            {
                list.Remove(nodeItem);
                break;
            }
        }
    }
    #endregion

    #region Conditions Methodes
    public static OOP.Event RetrieveEvent(int id, List<OOP.Event> list)
    {
        foreach (OOP.Event eventItem in list)
            if (eventItem.desiredEventValue == id)
                return eventItem;
        return null;
    }

    public static void ListConditions(List<OOP.Condition> list)
    {
        print($"\n<color=#00FF00> condition Type:     Node Id:     Event Id:     event Type:</color>");
        foreach (Condition conditionItem in list)
            print(conditionItem.conditionType + "     " + conditionItem.nodeId.ToString() + "     " + conditionItem.@event.desiredEventValue.ToString() + "     " + conditionItem.@event.eventType);
    }


    public static void RemoveCondition(string conditionType, List<Condition> list)
    {
        foreach (Condition conditionItem in list)
            if (conditionItem.conditionType == conditionType)
            { 
                list.Remove(conditionItem);
                break;
            }
    }
    #endregion

    #region Sounds Methodes
    public static void ListSounds(List<Sound> list)
    {
        print($"\n<color=#00FF00> Sound Id:     Sound Name:     Audio Type:     Audio URL:     Loop:" +
            $"     Volum:     Pitch:     Spatial Mode:     MinDistance:     MaxDistance:     Start Time:     EndTime:</color>");
        foreach (Sound soundItem in list)
            print(soundItem.objectId + "     " + soundItem.objectName + "     " + soundItem.audioType + "     " + soundItem.audioUrl + "     " 
                + soundItem.loop.ToString() + "     " + soundItem.volume.ToString() + "     " + soundItem.pitch.ToString() + "     " + soundItem.spatialMode + "     "
                + soundItem.minDistance.ToString() + "     " + soundItem.maxDistance.ToString() + "     " + soundItem.startTime.ToString()
                + "     " + soundItem.endTime.ToString());
    }


    public static void RemoveSound(string SoundId, List<Sound> list)
    {
        foreach (Sound soundItem in list)
            if (soundItem.objectId == SoundId)
            {
                list.Remove(soundItem);
                break;
            }
    }
    #endregion

    #region Characters Methodes
    public static void ListCharacters(List<Character> list)
    {
        print($"\n<color=#00FF00> id :     name :     startTime :     endTime :     model : </color>");
        foreach (Character characterItem in list)
            print(characterItem.id + "     " + characterItem.name + "     " + characterItem.startTime.ToString() + "     " + characterItem.endTime.ToString() + "     "
                + characterItem.model);
    }


    public static void RemoveCharacter(string CharacterId, List<Character> list)
    {
        foreach (Character characterItem in list)
            if (characterItem.id == CharacterId)
            {
                list.Remove(characterItem);
                break;
            }
    }
    #endregion

}