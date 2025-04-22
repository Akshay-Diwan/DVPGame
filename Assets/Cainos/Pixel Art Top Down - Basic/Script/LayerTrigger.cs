using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
namespace Cainos.PixelArtTopDown_Basic
{
    //when object exit the trigger, put it to the assigned layer and sorting layers
    //used in the stair objects for player to travel between layers
    public class LayerTrigger : MonoBehaviour
    {
        public string layer;
        public string sortingLayer;
        GameObject enemy;
        Seeker seeker;
        private void OnTriggerExit2D(Collider2D other)
        {
            Debug.Log("Trigger Exit at " + gameObject.name);
           
            other.gameObject.layer = LayerMask.NameToLayer(layer);

            other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName = sortingLayer;
            SpriteRenderer[] srs = other.gameObject.GetComponentsInChildren<SpriteRenderer>();
            Debug.Log(transform.parent.name);
            string VisualLayer = other.gameObject.GetComponent<SpriteRenderer>().sortingLayerName;
            int PhysicsLayer = other.gameObject.layer;
            foreach ( SpriteRenderer sr in srs)
            {
                sr.sortingLayerName = sortingLayer;
            }
            Debug.Log("other.tag = " + other.tag);
            if(other.tag == "Enemy"){
                enemy = other.gameObject;
                seeker = enemy.GetComponent<Seeker>();
                Debug.Log("Graphs: " + seeker.graphMask);
                if(layer == "Layer 2" || layer == "Layer 3"){
                    seeker.graphMask = 2;
                }
                else{
                    seeker.graphMask = 1;
                }
            }
        }

    }
}
