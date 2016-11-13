using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public class ToSpawn : MonoBehaviour {

     public Sprite sprite;
     public int value;
     void Start() {
          gameObject.AddComponent<SpriteRenderer>().sprite=sprite;
     }
}
