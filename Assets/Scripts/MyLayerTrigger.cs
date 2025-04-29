using UnityEngine;
using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
public class MyLayerTrigger: MonoBehaviour{
    public string L1;
    public string L2;
    private string sortingLayer;
    private Vector2 velocity;
    void OnTriggerExit2D(Collider2D other){
        Debug.Log("ON trigger for my trigger is working...");
        SpriteRenderer[] srs = other.gameObject.GetComponentsInChildren<SpriteRenderer>();
        // if(other.gameObject.layer == LayerMask.NameToLayer(L1)){
        //     other.gameObject.layer = LayerMask.NameToLayer(L2);
        //     other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = L2;
        //     sortingLayer = L2;
        // }
        // else{
        //     other.gameObject.layer = LayerMask.NameToLayer(L1);
        //     other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = L1;
        //     sortingLayer = L1;
            
        // }
        velocity = other.gameObject.GetComponent<Rigidbody2D>().linearVelocity; 
        Debug.Log("velocity: " + velocity);
        if(velocity.y > 0){
            other.gameObject.layer = LayerMask.NameToLayer(L2);
            other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = L2;
            sortingLayer = L2;
        
        }
        else{
            other.gameObject.layer = LayerMask.NameToLayer(L1);
            other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = L1;
            sortingLayer = L1;
        }
        foreach ( SpriteRenderer sr in srs)
            {
                sr.sortingLayerName = sortingLayer;
            }
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy"){
            other.gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.GetComponent<SortingGroup>().sortingLayerName = sortingLayer;    
        }
        

        // if(other.tag == "Enemy"){
        //     enemy = other.gameObject;
        //     seeker = enemy.GetComponent<Seeker>();
        //     Debug.Log("Graphs: " + seeker.graphMask);
        //     if(layer == "Layer 2" || layer == "Layer 3"){
        //         seeker.graphMask = 2;
        //     }
        //     else{
        //         seeker.graphMask = 1;
        //     }
        //     }
    }
}