using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camLook : MonoBehaviour
{
    public float sensitivity = 2f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        // Lock the cursor to the center of the screen and hide it
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get the mouse input
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Rotate the player's body based on horizontal mouse movement
        playerBody.Rotate(Vector3.up * mouseX);

        // Calculate vertical rotation for the camera
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        // Apply the rotation to the camera
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }

}