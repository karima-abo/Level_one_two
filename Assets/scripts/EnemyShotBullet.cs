using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotBullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject enemybullet;
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject Player;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, Player.transform.position);
        if (distance < 40)
        {
            timer += Time.deltaTime;
            if (timer > 2)
            {
                timer = 0;
                var enemyBulletInstance = Instantiate(enemybullet, firePoint.position, firePoint.rotation);
                Destroy(enemyBulletInstance, 3f);
            }

        }
    }
}
