using UnityEngine;

public class invader : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer sp;

    public float animationTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        InvokeRepeating("Animate", animationTime, animationTime);
    }

    void Animate()
    {

    }
}
