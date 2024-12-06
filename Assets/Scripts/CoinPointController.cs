using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPointController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HeroKnight heroKnight = other.GetComponent<HeroKnight>();
            CoinPoint coinUp = GetComponent<CoinPoint>();

            if (coinUp != null && heroKnight != null)
            {
                coinUp.ApplyCoinUp(heroKnight);
                Destroy(gameObject);
            }
        }
    }
}
