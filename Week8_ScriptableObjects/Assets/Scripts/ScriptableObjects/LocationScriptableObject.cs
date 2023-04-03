using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// allow us to have the scriptable object to appear in the unity editor and allow modifying it in the inspector
[CreateAssetMenu (
    fileName = "New location",
    menuName = "ScriptableObjects/Location",
    order = 0
    )]

public class LocationScriptableObject : ScriptableObject
{
    [TextArea]
    public string locationName;
    [TextArea]
    public string locationDescription;
    
    public LocationScriptableObject left;
    public LocationScriptableObject right;
    // public LocationScriptableObject westLocation;
    // public LocationScriptableObject eastLocation;
}
