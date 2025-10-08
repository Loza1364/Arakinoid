using UnityEngine;

public class audioManager : MonoBehaviour
{
    private audioManager instance;
    [Header("audioSource")]
    [SerializeField]
    private AudioSource music;
    [SerializeField]
    private AudioSource sfx;

    [Header("music")]
    public AudioClip background;
    public AudioClip background2;

    [Header("shoot")]
    public AudioClip shoot1;
    public AudioClip shoot2;
    public AudioClip shoot3;

    [Header("explode")]
    public AudioClip explode1;
    public AudioClip explode2;
    public AudioClip explode3;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        if (Random.Range(0, 2) == 0)
        {
            music.clip = background2;
        }
        else
        {
            music.clip = background;
        }
        music.Play();
    }

    public void Play(AudioClip name)
    {
        sfx.PlayOneShot(name);
    }
}
