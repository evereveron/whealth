using UnityEngine;
using System.Collections;

public class TrashMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Navigate to Castle
		GameObject player = GameObject.Find("Player");
		if (player)
			GetComponent<NavMeshAgent>().destination = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
