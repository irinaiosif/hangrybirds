using UnityEngine;
using System.Collections;

public class BugController : MonoBehaviour {

    float delta = 0.02f;

	// Use this for initialization
	void Start () {
        print("BUG::Movement initiated");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) )
        {
            Vector3 position = this.transform.position;
            position.x-= delta;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x+= delta;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.y+= delta;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.y-= delta;
            this.transform.position = position;
        }
    }
}
