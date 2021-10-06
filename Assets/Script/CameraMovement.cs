using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{   
    // Start is called before the first frame update
    public float Sensivity=100f;
    public Transform playerCharacter;
    float Rotation=0f;
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis=Input.GetAxis("Mouse X")*Sensivity*Time.deltaTime;
        float yAxis=Input.GetAxis("Mouse Y")*Sensivity*Time.deltaTime;
        Rotation -=yAxis;
        Rotation=Mathf.Clamp(Rotation,-90f,90f);

        transform.localRotation=Quaternion.Euler(Rotation,0f,0f);
        playerCharacter.Rotate(Vector3.up*xAxis);
    }
}
