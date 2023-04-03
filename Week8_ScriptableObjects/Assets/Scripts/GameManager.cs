using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    
    public LocationScriptableObject currentLocation;

    public Button left;
    public Button right;
    // public Button west;
    // public Button east;
    //
    
    // Start is called before the first frame update
    void Start()
    {
        TextAsset fileText = Resources.Load<TextAsset>("Data"); // only need to enter the name, because it's already looking for the TextAsset type
        
        Debug.Log(fileText);
        
        UpdateLocation();
    }

    void UpdateLocation()
    {
        title.text = currentLocation.locationName;
        description.text = currentLocation.locationDescription;

        if (currentLocation.left == null)
        {
            left.gameObject.SetActive(false);
        }
        else
        {
            left.gameObject.SetActive(true);
            currentLocation.left.right = currentLocation;
        }
        
        if (currentLocation.right == null)
        {
            right.gameObject.SetActive(false);
        }
        else
        {
            right.gameObject.SetActive(true);
            currentLocation.right.left = currentLocation;
        }

    }

    public void MoveDirection(int dir)
    {
        switch (dir)
        {
            case 0:
                currentLocation = currentLocation.left;
                break;
            case 1:
                currentLocation = currentLocation.right;
                break;
            // case 2:
            //     currentLocation = currentLocation.westLocation;
            //     break;
            // case 3:
            //     currentLocation = currentLocation.eastLocation;
            //     break;
        }
        
        UpdateLocation();
    }
}
