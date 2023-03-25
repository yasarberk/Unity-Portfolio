using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float fireSpeed = 10f;
    [SerializeField] float damage = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * fireSpeed); 
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        var attacker = collision.GetComponent<Attacker>();

        if ( attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }  
    }
}
