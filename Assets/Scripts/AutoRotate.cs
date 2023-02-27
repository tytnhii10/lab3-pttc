using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    private Rigidbody theRB;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody>();

        theRB.angularVelocity = Random.insideUnitSphere * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
