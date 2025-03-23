using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audiodata;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            audiodata = GetComponent<AudioSource>();
            if (audiodata.isPlaying)
                audiodata.Pause();
            else
                audiodata.Play();
        }

    }
}
