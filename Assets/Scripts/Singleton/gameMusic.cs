using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMusic : MonoBehaviour
{
    public static gameMusic Instance;
    public AudioClip music;

    // Use this for initialization
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance.gameObject);
        }
        else if (this != Instance)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void TouchButtonSound()
    {
        MakeSound(music);
    }

    /// Play a sound
    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}
