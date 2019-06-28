using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public GameObject ThrowObject;
    Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ThrowThing()
    {
        GameObject ThrowThing = Instantiate(ThrowObject);
        ThrowObject.transform.position = mainCamera.transform.position;
        var thR = ThrowThing.GetComponent<Rigidbody>();
        thR.AddForce( new Vector3(0,-1,0) * 1000 ,ForceMode.Impulse);
    } 


}
