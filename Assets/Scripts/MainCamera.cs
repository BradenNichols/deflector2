using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Vector3 cameraOffset;
    public float sensitivity = 2;

    private GameObject playerObject;
    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("Player");
        playerTransform = playerObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Position
        transform.position = playerTransform.position + cameraOffset;

        // Rotation
        float horizontal = Input.GetAxis("Mouse X") * sensitivity;
        float vertical = Input.GetAxis("Mouse Y") * sensitivity;

        transform.Rotate(vertical * -1, horizontal, 0);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);

        // TODO: try to rotate the player according to the camera.
        // then, make the camera offset be behind the player lookvector
    }
}
