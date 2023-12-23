using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHARACTORMOVEMENTall3axis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.S)) {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, -1);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.position += new Vector3(0, 0, 1);
        }

    }
}
