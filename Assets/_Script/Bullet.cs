using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public float flyTime;
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
        flyTime -= Time.deltaTime;
        if (flyTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
