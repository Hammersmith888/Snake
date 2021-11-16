using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
   public Vector3 originalPos = new Vector3 (0, 0 , 0);
   public int speed;
   enum State{
       none,
       forward,
       back,
       left,
       right
            
       
   }
   State state;
   void Update(){
       MainMovement();
   }
   void MainMovement(){
       if (Input.GetKey(KeyCode.W)){
           state = State.forward;
       }
       else if (Input.GetKey(KeyCode.S)){
           state = State.back;
       }
       else if (Input.GetKey(KeyCode.A)){
           state = State.left;
       }
       else if (Input.GetKey(KeyCode.D)){
           state = State.right;
       }
       if (Input.GetKey(KeyCode.W)){
           originalPos.z = originalPos.z + speed * Time.deltaTime;
       }
       else if (Input.GetKey(KeyCode.S)){
           originalPos.z = originalPos.z - speed * Time.deltaTime;
       }
       else if (Input.GetKey(KeyCode.A)){
           originalPos.x = originalPos.x - speed * Time.deltaTime;
       }
       else if (Input.GetKey(KeyCode.D)){
           originalPos.x = originalPos.x + speed * Time.deltaTime;
       }
       transform.position = new Vector3(Mathf.Floor(originalPos.x), transform.position.y, Mathf.Floor(originalPos.z));


   }
}
