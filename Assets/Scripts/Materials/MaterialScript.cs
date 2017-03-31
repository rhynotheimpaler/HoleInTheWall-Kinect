using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScript : MonoBehaviour {

    public Material wallMaterial;
    public Texture defaultMaterial;
    Texture wallTexture;

	// Use this for initialization
	void Start () {

        wallTexture = Resources.Load("BrickTexture") as Texture;
        if (wallTexture == null)
        {
            Debug.LogError("Texture has been set to default. Add texture named 'BrickTexture' to Resources Folder");
            wallMaterial.SetTexture("_MainTex", defaultMaterial);
        }
        else
        {
            wallMaterial.SetTexture("_MainTex", wallTexture);
        }


    }

    // Update is called once per frame
    void Update () {
		
	}
}
