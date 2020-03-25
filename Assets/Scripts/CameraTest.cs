using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraTest : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject cameraTest_text;
    Text cameratext;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera");
        cameraTest_text=GameObject.Find("CameraTest_text");
        cameratext = cameraTest_text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        cameratext.text = "x:" + mainCamera.transform.position.x+ "\ny:"+ mainCamera.transform.position.y+"\nz:" + mainCamera.transform.position.z;
    }
}
