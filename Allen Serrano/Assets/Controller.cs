using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody katawan;

    // Start is called before the first frame update
    void Start()
    {

        katawan = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        katawan.AddForce(movement * speed);
    }
}
