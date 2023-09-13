using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    private float x;
    private float y;
    public float sensitivity = -1f;
    public Vector3 rotate;

    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -12);

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        y = Input.GetAxis("Mouse X");
        x = Input.GetAxis("Mouse Y");
        rotate = new Vector3 (x, y * sensitivity, 0); 
        transform.eulerAngles = transform.eulerAngles - rotate;
        
        transform.position = player.transform.position + offset;
    }


}
