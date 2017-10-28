using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    public Camera cameraTop;
    public GameObject target;
    public float rotateSpeed = 5;
    Vector3 offset;

    void Start()
    {
        offset = target.transform.position - transform.position;
        cameraTop.enabled = false;
    }

    void Update()
    {

        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.transform.Rotate(0, horizontal, 0);

        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);

        transform.LookAt(target.transform);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            cameraTop.enabled = true;
        }

		if(Input.GetKey(KeyCode.RightShift))
			{
				cameraTop.enabled = false;
			}
    }
}
