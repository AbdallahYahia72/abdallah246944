using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{
   public Transform Enemy;
   public Transform SpawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RespawnEnemy(){
        Instantiate(Enemy,SpawnPoint.transform.position,SpawnPoint.transform.rotation);
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Player"){
            RespawnEnemy();
        }
    }
}
