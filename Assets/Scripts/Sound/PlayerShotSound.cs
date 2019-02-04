using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotSound : MonoBehaviour
{
    public static PlayerShotSound Instance;
    public AudioClip playerShotSound;

    // Use this for initialization
    void Start()
    {
        Instance = this;
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
