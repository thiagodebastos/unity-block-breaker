using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    public LevelManager levelManager;
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        Debug.Log(trigger);
        levelManager.LoadLevel("Lose Screen");
    }

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
