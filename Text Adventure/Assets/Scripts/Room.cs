using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/Room")]
public class Room : ScriptableObject
{
    [TextArea]
    public string description;
    public Exit[] exits;
    public InteractableObject[] interactableObjectsInRoom;
    public string roomName;
}
