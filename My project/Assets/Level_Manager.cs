using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Manager : MonoBehaviour
{
   public Transform player;
   public GameObject CurrentCheckpoint;
    void Start()
    {
        CurrentCheckpoint=null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnPlayer(){
            FindObjectOfType<PlayerController>().transform.position=CurrentCheckpoint.transform.position;
        }
}
