using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{

    public float rotationSpeed = 1;
    public Transform Target, Player;
    float mouseX;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        CamControl();
    }

    void CamControl() 
    {
        // mouseX = Input.GetAxis ("Mouse X") * rotationSpeed * Time.deltaTime;
        transform.LookAt(Target);

        // Target.Rotate(0, mouseX, 0);// = Quaternion.Euler(0, mouseX, 0);
        // Player.Rotate(0, mouseX, 0);// = Quaternion.Euler(0, mouseX, 0);
    }
}
