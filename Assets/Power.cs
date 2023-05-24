using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : PickUp
{
    public Sprite mad;
    public Sprite nuetral;

    public override void Activate()
    {
        player.Ispowered = true;
        SR.sprite = mad;
        StartCoroutine(PowerTimer());
    }

    IEnumerator PowerTimer()
    {
        yield return new WaitForSeconds(5);

        player.Ispowered = false;
        SR.sprite = nuetral;
    }
}
