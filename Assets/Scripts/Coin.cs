using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : CoinPoint
{
    public int CoinIncrease;

    private void Start()
    {
        CoinIncrease = 10;
    }

    public override void ApplyCoinUp(HeroKnight heroKnight)
    {
        heroKnight.CoinUp(CoinIncrease);
    }
}
