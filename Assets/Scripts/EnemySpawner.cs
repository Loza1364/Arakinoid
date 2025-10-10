using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public invader[] enemyPrefabs;
    public int row = 5;
    public int columns = 11;


    void Awake()
    {
        for (int row = 0; row < this.row; row++ )
        {
            float width = 2 * (this.columns - 1);
            float height = 2 * (this.row - 1);
            Vector2 centerOffset = new Vector2(-width / 2, -height / 2);
            Vector3 rowPosition = new Vector3(centerOffset.x,centerOffset.y + (row * 2), 0);
            for (int col = 0; col < this.columns; col++)
            {
                invader invader = Instantiate(this.enemyPrefabs[row], this.transform);
                Vector3 position = rowPosition;
                position.x += col * 2;
                invader.transform.position = position;

            }
        }
    }
}
