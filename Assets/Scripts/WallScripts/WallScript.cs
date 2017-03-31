using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {

    float offset;
    public Renderer rend;

	// Use this for initialization
	void Start () {

        rend = GetComponent<Renderer>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        offset += GameManager.wallsScrollSpeed * Time.fixedDeltaTime;
        rend.material.SetTextureOffset("_MainTex", new Vector2(-offset, 0));
    }
}
