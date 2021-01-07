using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    public float sensitivity = 100f;
    public Transform body;
    public float up_down_rotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") *sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") *sensitivity * Time.deltaTime;
        body.Rotate(Vector3.up, mouseX);
        up_down_rotation -= mouseY;
        up_down_rotation = Mathf.Clamp(up_down_rotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(up_down_rotation, 0f,0f);
    }
}
