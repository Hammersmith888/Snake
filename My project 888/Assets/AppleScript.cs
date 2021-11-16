using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleScript : MonoBehaviour
{
    public GameObject applePrefab, apple;
    int score = 0;
    public Text scoreText;
    private void Start(){
        apple = Instantiate(applePrefab, new Vector3(Random.Range(-24, 24), 0.75f, Random.Range(-24, 24)), Quaternion.identity);
    }
    public  void Spawn(){
        apple = Instantiate(applePrefab, new Vector3(Random.Range(-24, 24), 0.75f, Random.Range(-24, 24)), Quaternion.identity);
    }
    void OnTriggerEnter(Collider col){
        if (col.gameObject.CompareTag("Apple")){
            score++;
            scoreText.text = score.ToString();
            Destroy(apple);
            Spawn();
        }
    }

    
    
        
            

        

    
}
