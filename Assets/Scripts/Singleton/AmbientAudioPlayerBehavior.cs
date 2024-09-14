using UnityEngine;

public class AmbientAudioPlayerBehavior : MonoBehaviour
{
    private static AmbientAudioPlayerBehavior instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    private AmbientAudioPlayerBehavior()
    {

    }

    public void FadeNewMusic(AudioClip clip)
    {
        // TODO
    }
}
