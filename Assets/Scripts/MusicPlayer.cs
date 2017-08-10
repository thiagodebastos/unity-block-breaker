using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;

    void Awake()
    {
        Debug.Log("MusicPlayer Awake " + GetInstanceID());
        // if an instance of MusicPlayer already exists, self-destruct
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            // claim the instance
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        Debug.Log("MusicPlayer Start " + GetInstanceID());

    }
}
