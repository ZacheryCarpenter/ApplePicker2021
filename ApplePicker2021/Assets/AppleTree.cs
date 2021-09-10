using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    
    [Header("Set in Inspector")]
    //Prefab for instantiating apples
    public GameObject applePrefab;
    //spped at which the apple tree moves
    public float speed = 1f;
    //distance where apple tree turns around
    public float leftAndRightEdge = 10f;
    //chance that the apple tree will change directions
    public float chancToChangeDirections = 0.1f;
    //rate at which Apples will be instantiated
    public float secondBetweenAppleDrops = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        //dropping apples every seconds   


    }

    // Update is called once per frame
    void Update()
    {
        //basic movement

        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        

        //changing direction
    }
}
