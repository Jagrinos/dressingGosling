using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerasize : MonoBehaviour
{
    [SerializeField] GameObject mainWindow;

    void Awake()
    {
        float ratio = (float)Screen.height / Screen.width;
        float ortSize = mainWindow.GetComponent<SpriteRenderer>().size[0] * 100 * ratio / 200f;
        Camera.main.orthographicSize = ortSize;
    }
}
