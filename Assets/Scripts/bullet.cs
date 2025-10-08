using UnityEngine;

public class bullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 7);
        if (transform.position.y > 10)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "invader")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
