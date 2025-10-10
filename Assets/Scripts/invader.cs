using UnityEngine;

public class invader : MonoBehaviour
{
    public Sprite[] sprites;
    private int spriteIndex = 0;
    private SpriteRenderer sp;

    public float animationTime = 1f;

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
        spriteIndex++;
        if (spriteIndex > sprites.Length)
        {
            spriteIndex = 0;
        }
        sp.sprite = sprites[spriteIndex];
    }
}
