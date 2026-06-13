using UnityEngine;

public class RotateObject : MonoBehaviour
{

public float rotate;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.rotation = Quaternion.Euler(0, Rotation,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(rotate, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(-rotate, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, rotate, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, -rotate, 0);
        }
    }
}
