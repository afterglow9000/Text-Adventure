using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Interaction
{
    public ActionResponse actionResponse;
    public InputAction inputAction;
    [TextArea]
    public string textResponse;
}
