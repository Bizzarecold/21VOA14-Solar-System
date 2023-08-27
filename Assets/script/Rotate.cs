using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //declaring a variable to select the rotation targer 
  public Transform target;
  public int speed;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //rotate around the first target postion 
        //rotate around need second parameter about the axis or rotation
        //rotate around third parameter needed is the speed of rotation
       transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
