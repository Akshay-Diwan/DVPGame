// using UnityEngine;

// public class Level1to2Trigger : MonoBehaviour
// {
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
//   private void OnTriggerEnter2D(Collider2D other) {   
//        // Destroy the collectible
//        SpriteRenderer sr = other.gameObject.GetComponent<SpriteRenderer>();
//        if(sr != null){
//             string sortingLayer = sr.sortingLayerName;
//             Debug.Log("Sorting Order: " + sortingLayer + ", Physics Layer: " + other.gameObject.layer);
//             sr.sortingLayerName = "Layer 2";
//             other.gameObject.layer = LayerMask.NameToLayer("Layer 2");

//        }
//        else{
//         Debug.Log("sr is null");
//        }
// }
// }
