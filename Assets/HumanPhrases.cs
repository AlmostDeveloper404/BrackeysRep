using UnityEngine;
using System.Collections;

public class HumanPhrases : MonoBehaviour
{
    AudioManager audioManager;

    private void Start()
    {
        audioManager = AudioManager.instance;
        StartCoroutine(RandomPhrases());
    }

    IEnumerator RandomPhrases()
    {
        while (true)
        {
            audioManager.audios[1].Play();
            yield return new WaitForSeconds(5f);
        }
    }


}
