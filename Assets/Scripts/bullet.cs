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
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("invader"))
        {
            Debug.Log("Hit invader");
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
