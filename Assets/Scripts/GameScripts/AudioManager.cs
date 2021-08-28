using UnityEngine;

public class AudioManager : MonoBehaviour
{
    #region Singleton
    public static AudioManager instance;
    private void Awake()
    {
        if (instance!=null)
        {
            Debug.LogWarning("More than one AudioManager!");
            return;
        }
        instance = this;
    }
    #endregion

    public AudioSource[] audios;

    private void Start()
    {
        audios = new AudioSource[transform.childCount];
        for (int i = 0; i < audios.Length; i++)
        {
            audios[i] = transform.GetChild(i).GetComponent<AudioSource>(); ;
        }
    }
}
