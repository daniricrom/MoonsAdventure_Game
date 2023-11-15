using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venator : MonoBehaviour
{
    public float speed = 1f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Right"))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

        }
        if (Input.GetButton("Left"))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));

        }

        if (Input.GetButton("Up"))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }

        if (Input.GetButton("Down"))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
    }
}
