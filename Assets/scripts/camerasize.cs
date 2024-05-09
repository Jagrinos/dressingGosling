using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerasize : MonoBehaviour
{
    [SerializeField] GameObject objects;
    
    void Update() //awake
    {
        // float ratio = (float)Screen.height / Screen.width;

        // float ortSize = objects.GetComponent<SpriteRenderer>().size[0] * 100 * ratio / 200f;
        // Camera.main.orthographicSize = ortSize;
       
    }
}
