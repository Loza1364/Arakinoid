using UnityEngine;

public class bullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 13);
        if (transform.position.y > 16)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit something");
        if (other.gameObject.CompareTag("invader"))
        {
            Debug.Log("Hit invader");
            Destroy(other.gameObject);
        }
    }
}
