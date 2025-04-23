using UnityEngine;
using UnityEngine.Playables;

public class AnimationStarter : MonoBehaviour
{
    public PlayableDirector playableDirector;

    public void OnReceiveMessage(int value)
    {
        if (value == 1)
        {
            playableDirector.Play();
        }

        if (value == 0)
        {
            playableDirector.Stop();
        }
    }
}
