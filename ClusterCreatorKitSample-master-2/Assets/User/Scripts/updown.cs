using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z)) {
            this.transform.localScale = new Vector3(1, 1.1f, 1);
        } else if (Input.GetKey(KeyCode.X)) {
            this.transform.localScale = new Vector3(1, 0.9f, 1);
        }
    }
}
