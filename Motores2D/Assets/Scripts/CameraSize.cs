using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    [SerializeField]
    Camera cam;

    [SerializeField]
    private float _size;
    
    public void Update(){
        ChangeSize();
    }

    public void ChangeSize(){
        float width = _size / Screen.width;
        float height = _size / Screen.height;

        float cameraLandscape = 0.5f * width * Screen.width;
        float cameraPortrait = 0.5f * height * Screen.height;

        cam.fieldOfView = cameraLandscape;
    }
}
