using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] GameObject playerbullet;
    [SerializeField] GameObject firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            var playerBulletInstance= Instantiate(playerbullet, firePoint.transform.position, firePoint.transform.rotation);
            Destroy(playerBulletInstance, 2f);
        }
    }
}
