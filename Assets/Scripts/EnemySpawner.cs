using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public invader[] enemyPrefabs;
    public int row = 5;
    public int columns = 11;
    public float spacing = 4f;

    private Vector3 _direction = Vector2.right;
    public float speed = 1f;


    void Awake()
    {
        for (int row = 0; row < this.row; row++ )
        {
            float width = spacing * (this.columns - 1);
            float height = spacing * (this.row - 1);
            Vector2 centerOffset = new Vector2(-width / 2, -height / 2);
            Vector3 rowPosition = new Vector3(centerOffset.x,centerOffset.y + (row * spacing), 0);
            for (int col = 0; col < this.columns; col++)
            {
                invader invader = Instantiate(this.enemyPrefabs[row], this.transform);
                Vector3 position = rowPosition;
                position.x += col * spacing;
                invader.transform.localPosition = position;

            }
        }
    }

    private void Update()
    {
        this.transform.position += _direction * this.speed * Time.deltaTime;

        Vector3 leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        Vector3 rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
        foreach (Transform invader in this.transform)
        {
            if (!invader.gameObject.activeInHierarchy)
            {
                continue;
            }
            if (_direction == Vector3.right && invader.position.x > rightEdge.x)
            {
                AdvanceRow();
            }
            else if (_direction == Vector3.left && invader.position.x < leftEdge.x)
            {
                AdvanceRow();
            }
        }
    }
    void AdvanceRow()
    {
        _direction *= 1;
        Vector3 position = this.transform.position;
        position.y -= 1.0f;
        this.transform.position = position;
    }
}
