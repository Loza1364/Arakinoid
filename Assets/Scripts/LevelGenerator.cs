using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject bunker;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(bunker, new Vector3(Vector3.left.x + (i * 8)-(11), -10f, 0), Quaternion.identity);
        }
    }
}
