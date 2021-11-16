using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeControler : MonoBehaviour
{
    [SerializeField] KeyCode keyOne;
    [SerializeField] KeyCode keyTwo;
    [SerializeField] KeyCode keyThree;
    [SerializeField] KeyCode keyFour;
    [SerializeField] Vector3 moveDirection;

    private void FixedUpdate() {
        if (Input.GetKey(keyOne)){
            GetComponent<Rigidbody>().velocity += moveDirection;
        
        }
        if (Input.GetKey(keyTwo)) {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(keyThree)){
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(keyFour)){
            GetComponent<Rigidbody>().velocity += moveDirection;
        }



    }


    
}
