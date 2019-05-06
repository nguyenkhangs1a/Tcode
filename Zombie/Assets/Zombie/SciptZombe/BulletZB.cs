using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletZB : MonoBehaviour {
    [SerializeField]
    private int dame;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("Getdame");
            col.transform.gameObject.GetComponent<MovePlayer>().Gethit(dame);
            Destroy(gameObject);
        }
    }
}
