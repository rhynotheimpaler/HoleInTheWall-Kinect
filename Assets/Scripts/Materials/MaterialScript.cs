using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScript : MonoBehaviour {

    public Material wallMaterial;
    public Texture defaultMaterial;
    Texture wallTexture;



	// Use this for initialization
	void Start () {
        string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "CustomTexture");
        StartCoroutine(GetTextureFromStreaming(filePath));
        //print(filePath);
        //wallTexture = Resources.Load("BrickTexture") as Texture;
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

    IEnumerator GetTextureFromStreaming(string path)
    {
        print(path);
        Texture tex;
        WWW localFile;
        localFile = new WWW(path);
        if (localFile.isDone)
        {
            tex = localFile.texture;
            wallTexture = tex;
            yield return tex;
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
