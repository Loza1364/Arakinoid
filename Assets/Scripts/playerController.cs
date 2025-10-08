using UnityEngine;

public class playerController : MonoBehaviour
{
    private audioManager sfx;

    public GameObject bulletPrefab;

    void Start()
    {
        sfx = FindFirstObjectByType<audioManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sfx.Play(sfx.shoot1);
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }
}
