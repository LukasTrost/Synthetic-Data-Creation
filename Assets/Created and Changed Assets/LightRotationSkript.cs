using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotationSkript : MonoBehaviour
{
    public float rotationXMin = 30;
    public float rotationXMax = 80;
    public float rotationYMin = -50;
    public float rotationYMax = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationX = Random.Range(rotationXMin,rotationXMax);
        float rotationY = Random.Range(rotationYMin,rotationYMax);
        transform.rotation = Quaternion.Euler(rotationX, rotationY, transform.rotation.eulerAngles.z);

    }
}
