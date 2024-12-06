using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : Weapon
{
    [SerializeField] private float speed;
    bool hasHit;

    public void Start()
    {
        Damage = 20;
        speed = 5.0f * GetShootDiection();
        hasHit = false;
        Move();
    }
    private void FixedUpdate()
    {
        Move();
    }
    public override void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
    }
    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            hasHit = true;
            Destroy(this.gameObject);
            character.TakeDamage(this.Damage);
        }
    }
}
