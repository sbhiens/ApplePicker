using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]   //places a header line above the following fields in the Inspector
    public GameObject applePrefab;  //Prefab for instantiating apples

    public float speed = 1f;    //Speed at which AppleTree moves

    public float leftAndRightEdge = 10f;    //Distance where AppleTree turns around

    public float changeDirChance = 0.1f;    //Chance that AppleTree will change directions

    public float appleDropDelay = 0.1f;     //Seconds between Apples instantiations

    void Start()    // Start is called before the first frame update
    {
        
    }

    
    void Update()   // Update is called once per frame
    {
        
    }
}
