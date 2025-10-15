using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject bunker;
    public float distance = 8f;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Vector3 position = new Vector3(Vector3.left.x + ( (i * distance) - ( ((4-1.25f) * distance)/2) ), -10,0f);
            Instantiate(bunker, position, Quaternion.identity);
        }
    }
}
