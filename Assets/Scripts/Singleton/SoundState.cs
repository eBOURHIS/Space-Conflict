using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundState : MonoBehaviour
{
    public static SoundState Instance;
    public AudioClip playerShotSound;

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
            Debug.Log("Détruit");
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TouchButtonSound()
    {
        MakeSound(playerShotSound);
    }

    /// Play a sound
    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}
