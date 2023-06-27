using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAndPositionSkript : MonoBehaviour
{
    public Vector3  positionMin;
    public Vector3  positionMax;
    public Vector3 mistakenPerspectiveVector;

    public float rotations_per_second = 360.0f;
    public bool rotate_in_x = true;
    public bool rotate_in_y = true;
    public bool rotate_in_z = true;
    public bool rotate_randomly = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float positionX = Random.Range(positionMin.x, positionMax.x);
        float positionY = Random.Range(positionMin.y, positionMax.y);
        float positionZ = Random.Range(positionMin.z, positionMax.z);
        if (rotate_randomly == false)
        {
            if (rotate_in_y)
            {
                transform.Rotate(0f, rotations_per_second * Time.deltaTime, 0f);
            }
            if (rotate_in_z)
            {
                transform.Rotate(0f, 0f, rotations_per_second * Time.deltaTime);
            }
            if (rotate_in_x)
            {
                transform.Rotate(rotations_per_second * Time.deltaTime, 0f, 0f);
            }
        }
        else
        {
            if (rotate_in_y)
            {
                float rotationY = Random.Range(0, 360);
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, rotationY, transform.rotation.eulerAngles.z);
            }
            if (rotate_in_z)
            {
                float rotationZ = Random.Range(0, 360);
                transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, rotationZ);
            }
            if (rotate_in_x)
            {
                float rotationX = Random.Range(0, 360);
                transform.rotation = Quaternion.Euler(rotationX, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            }
        }
        transform.position = new Vector3(positionX + mistakenPerspectiveVector.x , positionY + mistakenPerspectiveVector.y, positionZ + mistakenPerspectiveVector.z);
    }
}
