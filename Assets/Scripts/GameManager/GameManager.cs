using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty { easy, medium, hard }

public class GameManager : MonoBehaviour {

    public static int wallsPassed;
    public static int wallsSpawned;

    public Difficulty currentDifficulty;

    [SerializeField]
    int easyMultiplier = 1;
    [SerializeField]
    int mediumMultiplier = 2;
    [SerializeField]
    int hardMultiplier = 4;

    private int difficultyMultiplier;

    [SerializeField]
    [Header("The speed at which the walls scroll")]
    float scrollSpeed;
    public static float wallsScrollSpeed;
    [SerializeField]
    [Header("The speed that the obstacles move")]
    float floorSpeed;
    public static float floorMovementSpeed;
    [SerializeField]
    [Header("The time between obstacle spawns")]
    float spawnDelay;
    public static float wallSpawnDelay;

    // Use this for initialization
    void Start () {

        if (GameObject.FindGameObjectWithTag("MainCamera") == null)
        {
            Debug.LogError("You must insert a Camera tagged with 'MainCamera' into the scene");
        }

        wallsPassed = 0;

        wallsScrollSpeed = scrollSpeed;
        floorMovementSpeed = floorSpeed;
        wallSpawnDelay = spawnDelay;

        currentDifficulty = Difficulty.easy;
        difficultyMultiplier = easyMultiplier;

        UpdateDifficulty();
    }

    void FixedUpdate () {

        switch (currentDifficulty)
        {
            case Difficulty.easy:
                difficultyMultiplier = easyMultiplier;
                break;
            case Difficulty.medium:
                difficultyMultiplier = mediumMultiplier;
                break;
            case Difficulty.hard:
                difficultyMultiplier = hardMultiplier;
                break;
            default:
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            UpdateDifficulty();
        }
    }

    void UpdateDifficulty()
    {

        wallsScrollSpeed *= difficultyMultiplier;
        floorMovementSpeed *= difficultyMultiplier;
        wallSpawnDelay /= difficultyMultiplier;

    }
}
