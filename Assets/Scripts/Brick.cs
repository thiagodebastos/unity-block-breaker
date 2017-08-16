using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private LevelManager levelManager;
    public int maxHits;
    private int timesHit;
    // Use this for initialization
    void Start()
    {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timesHit == maxHits)
        {
            DestroyObject(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        timesHit++;
        SimulateWin();
    }

    // TODO: remove this method once we can actually win!
    void SimulateWin()
    {
        levelManager.loadNextLevel();
    }
}
