﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Sprite[] hitSprites;

    private int timesHit;
    private LevelManager levelManager;
    // Use this for initialization
    void Start()
    {
        timesHit = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        bool isBreakable = (this.tag == "Breakable");
        if (isBreakable)
        {
            HandleHits();
        }
    }
    void HandleHits()
    {
        timesHit++;
        // remove the need for manually setting maxHits from within unity
        int maxHits = hitSprites.Length + 1;
        // use >= instead of == to protect ourselves in case we skip over max hits
        if (timesHit >= maxHits)
        {
            DestroyObject(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }


    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }

    // TODO: remove this method once we can actually win!
    void SimulateWin()
    {
        levelManager.loadNextLevel();
    }
}
