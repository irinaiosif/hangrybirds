using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawn: MonoBehaviour {
     public GameObject background;
     public List<ToSpawn> spawnList=new List<ToSpawn>();
     List<GameObject> clones = new List<GameObject>();

     void SpawnMet(GameObject prefab) {
          GameObject clone;
          clone=Instantiate(prefab.gameObject);
          clone.transform.SetParent(background.transform);
          clone.transform.localScale=Vector3.one;
          clones.Add(clone);
     }
     void Update() {
          
     }
}
