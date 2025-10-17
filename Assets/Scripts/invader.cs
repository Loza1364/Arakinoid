using UnityEngine;

public class invader : MonoBehaviour
{
    public Sprite[] sprites;
    private int spriteIndex = 0;
    private SpriteRenderer sp;
    private audioManager sfx;

    public float animationTime = 1;
    public System.Action killed;

    void Awake()
    {
        sfx = FindFirstObjectByType<audioManager>();
        sp = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        InvokeRepeating("Animate", animationTime, animationTime);
    }

    void Animate()
    {
        spriteIndex++;
        if (spriteIndex > sprites.Length - 1)
        {
            spriteIndex = 0;
        }
        sp.sprite = sprites[spriteIndex];
    }
    public void DestroyInvader()
    {
        sfx.Play(sfx.explode1);
        this.gameObject.SetActive(false);
    }
}
