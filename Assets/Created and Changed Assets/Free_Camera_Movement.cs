using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Perception.GroundTruth;

public class Free_Camera_Movement : MonoBehaviour
{
   
    public float speed = 10.0f;
    public float sensitivity = 2.0f;
    [SerializeField] PerceptionCamera perceptionCamera;
    [SerializeField] PerceptionCamera xrayCamera;
    [SerializeField] Camera XRayCameraObject;

    bool isCapturing = false;

    void Awake()
    {
        perceptionCamera.enabled = isCapturing;
        if (XRayCameraObject.gameObject.activeSelf == true)
        {
            xrayCamera.enabled = isCapturing;
        }
        
    }
    void Start()
    {
        perceptionCamera.enabled = isCapturing;
        if (XRayCameraObject.gameObject.activeSelf == true)
        {
            xrayCamera.enabled = isCapturing;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Move the camera
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);

        // Rotate the camera with the mouse
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        float xRotation = currentRotation.y + mouseX * sensitivity;
        float yRotation = currentRotation.x - mouseY * sensitivity;

        transform.localRotation = Quaternion.Euler(yRotation, xRotation, 0);

        if (Input.GetKeyDown(KeyCode.C))
        {
            isCapturing = !isCapturing;
            perceptionCamera.enabled = isCapturing;

            if (XRayCameraObject.gameObject.activeSelf == true)
            {
                xrayCamera.enabled = isCapturing;
            }
        }
    }
}
