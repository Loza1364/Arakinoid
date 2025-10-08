using System;
using Unity.VisualScripting;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public Sprite[] sprites;
    private int spriteIndex;

    private SpriteRenderer spriteRenderer;
    private audioManager sfx;

    public GameObject bulletPrefab;
    public GameObject particle;

    private float xInput = 0;

    void Start()
    {
        spriteIndex = sprites.Length - 1;
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("ChangeSprite", .075f, .075f);
        sfx = FindFirstObjectByType<audioManager>();
    }
    private void ChangeSprite()
    {
        spriteIndex++;
        if (spriteIndex >= sprites.Length - 1)
        {
            spriteIndex = sprites.Length - 1;
        }
        spriteRenderer.sprite = sprites[spriteIndex];
    }

    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        if ( spriteIndex > 1)
        {
            transform.Translate(Vector3.right * xInput * Time.deltaTime * 4);
        }
        if (Input.GetKeyDown(KeyCode.Space) && spriteIndex > 3)
        {
            spriteIndex = 0;
            Vector3 placement = new Vector3(transform.position.x, transform.position.y + 1, 0);
            Instantiate(bulletPrefab, placement, Quaternion.identity);
            Instantiate(particle, placement, Quaternion.identity);
            int random = UnityEngine.Random.Range(1, 4);
            if (random == 1)
            {
                sfx.Play(sfx.shoot1);
            }
            else if (random == 2)
            {
                sfx.Play(sfx.shoot2);
            }
            else
            {
                sfx.Play(sfx.shoot3);
            }
        }
    }
}
