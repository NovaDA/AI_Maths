using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : MonoBehaviour
{
    public GameObject objectToIgnore;
    public int Damage = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider == objectToIgnore.GetComponent<Collider2D>())
        {
            Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<Collider2D>());
        }
    }
}
