using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLabelSkript : MonoBehaviour
{
    public Vector3  positionMin;
    public Vector3  positionMax;

    public bool rotate_in_x = true;
    public bool rotate_in_y = true;
    public bool rotate_in_z = true;

    public Vector2 rotation_minmax_x;
    public Vector2 rotation_minmax_y;
    public Vector2 rotation_minmax_z;

    public float base_rotation_x;
    public float base_rotation_y;
    public float base_rotation_z;

    // Start is called before the first frame update
    void Start()
    {
        //base_rotation_x = transform.rotation.eulerAngles.x;
        //base_rotation_y = transform.rotation.eulerAngles.y;
        //base_rotation_z = transform.rotation.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        float positionX = Random.Range(positionMin.x, positionMax.x);
        float positionY = Random.Range(positionMin.y, positionMax.y);
        float positionZ = Random.Range(positionMin.z, positionMax.z);

        if (rotate_in_x && rotate_in_y)
        {
            float rotationX = Random.Range(rotation_minmax_x.x, rotation_minmax_x.y);
            float rotationY = Random.Range(rotation_minmax_y.x, rotation_minmax_y.y);
            transform.rotation = Quaternion.Euler(rotationX, rotationY, base_rotation_z);
        }
        else if (rotate_in_x)
        {
            float rotationX = Random.Range(rotation_minmax_x.x, rotation_minmax_x.y);
            transform.rotation = Quaternion.Euler(rotationX, base_rotation_y, base_rotation_z);
        }
        else if (rotate_in_y)
        {
            float rotationY = Random.Range(rotation_minmax_y.x, rotation_minmax_y.y);
            transform.rotation = Quaternion.Euler(base_rotation_x, rotationY, base_rotation_z);
        }
        else if (rotate_in_z)
        {
            float rotationZ = Random.Range(rotation_minmax_z.x, rotation_minmax_z.y);

            transform.rotation = Quaternion.Euler(base_rotation_x, base_rotation_y, rotationZ);

        }
        
        transform.position = new Vector3(positionX, positionY, positionZ);
    }
}
