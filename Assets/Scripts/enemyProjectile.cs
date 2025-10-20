using UnityEngine;

public class enemyProjectile : MonoBehaviour
{
    public float speed = 10f;
    private SpriteRenderer sp;
    public Sprite[] sprites;
    private int index = 0;

    private void Start()
    {
        InvokeRepeating("animate", .075f,.075f);
        sp = GetComponent<SpriteRenderer>();
    }

    void animate()
    {
        index++;
        if (index > sprites.Length - 1)
        {
            index = 0;
        }
        sp.sprite = sprites[0];
    }
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y + 1 < Camera.main.ViewportToWorldPoint(Vector3.zero).y)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bunker"))
        {
            Destroy(gameObject);
        }
    }
}
