using UnityEngine;

public class Player : MonoBehaviour
{


    public float rotate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }






        if(Input.GetKey(KeyCode.Space))
        {
            
            transform.rotation *= Quaternion.Euler(0, 1f, 0);
        }







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
            transform.rotation *= Quaternion.Euler(0, 0, rotate);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 0, -rotate);
        }
        
    }
}
