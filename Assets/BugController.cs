using UnityEngine;
using System.Collections;

public class BugController : MonoBehaviour {

    float delta = 0.01f;
	// Use this for initialization
	void Start () {
        print("zuzuz");
	
	}

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) )
        {
            Vector3 position = this.transform.position;
               position.x-= delta;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x+= delta;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.y+= delta;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.y-= delta;
            this.transform.position = position;
        }
    }
}
