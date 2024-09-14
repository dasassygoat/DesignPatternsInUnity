using UnityEngine;

public class AmbientAudioPlayer
{
    private static AmbientAudioPlayer instance = null;

    public static AmbientAudioPlayer GetInstance()
    {
        return instance ?? (instance = new AmbientAudioPlayer());
    }

    private AmbientAudioPlayer()
    {

    }

    public void FadeNewMusic(AudioClip audioClip){

    }
}
