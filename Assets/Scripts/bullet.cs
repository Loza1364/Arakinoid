using UnityEngine;

public class bullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 13);
 
        if (transform.position.y - 1 > Camera.main.ViewportToWorldPoint(Vector3.up).y)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            collision.gameObject.BroadcastMessage("DestroyInvader");
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("Bunker"))
        {
            Destroy(this.gameObject);
        }
    }
}
