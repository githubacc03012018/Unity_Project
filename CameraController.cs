using UnityEngine;

public class CameraController : MonoBehaviour {

    Transform attachPoint;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        attachPoint = GameObject.Find("CameraPosition").transform;
        this.transform.position = attachPoint.position;
    }
}
