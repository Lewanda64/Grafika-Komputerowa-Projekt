using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5.0f;  
    public float rotateSpeed = 100.0f;  

    private float pitch = 0.0f; 
    private float yaw = 0.0f;   

    void Update()
    {
        
        float moveHorizontal = 0;
        float moveVertical = 0;

        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveVertical = -1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1;
        }

        
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * moveSpeed * Time.deltaTime;
        movement = transform.TransformDirection(movement);

        
        transform.Translate(movement, Space.World);

       
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            yaw -= rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            yaw += rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pitch -= rotateSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pitch += rotateSpeed * Time.deltaTime;
        }

        
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
