using UnityEngine;

public class particleFire : MonoBehaviour
{
    public Sprite[] sprites;
    private int index = 0;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        index = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("changeSprite", 0.075f, 0.075f);
    }

    private void changeSprite()
    {
        if (index < sprites.Length)
        {
            spriteRenderer.sprite = sprites[index];
            index++;
        }
        else
        {
            CancelInvoke("changeSprite");
            Destroy(this.gameObject);
        }
    }
}
