using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

    public float movementSpeed;
    public Renderer rend;

    Camera playerCamera;

    void Start () {
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        IncreaseWallsSpawned();
	}
	
	void FixedUpdate () {

        movementSpeed = GameManager.floorMovementSpeed;
        transform.Translate(Vector3.up * GameManager.floorMovementSpeed * Time.fixedDeltaTime);

        if (this.transform.position.y > (playerCamera.gameObject.transform.position.y - playerCamera.nearClipPlane))
        {
            IncreaseScore();
        }
    }

    void IncreaseWallsSpawned()
    {
        GameManager.wallsSpawned++;
    }
    void IncreaseScore()
    {
        GameManager.wallsPassed++;
        print(GameManager.wallsPassed.ToString());
        Destroy(gameObject);
    }
}
