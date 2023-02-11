using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]   //places a header line above the following fields in the Inspector
    public GameObject applePrefab;  //Prefab for instantiating apples

    public float speed = 1f;    //Speed at which AppleTree moves

    public float leftAndRightEdge = 40f;    //Distance where AppleTree turns around

    public float percentChangeDirection = 10f;    //Chance that AppleTree will change directions
   
   void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
        apple.transform.position = transform.position;

        Invoke("DropApple", 0.8f);
    }

    void Start()    // Start is called before the first frame update
    {
        Invoke("DropApple", 2f);
    }
    
    void Update()   // Update is called once per frame
    {
        //Basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if ((pos.x < -leftAndRightEdge && speed < 0) || (pos.x > leftAndRightEdge && speed > 0))
        {
            speed *= -1f;
        }
    }

    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        if (-leftAndRightEdge <= pos.x && pos.x <= leftAndRightEdge && UnityEngine.Random.value < percentChangeDirection)
        {
            speed *= -1f;
        }
    }
}
