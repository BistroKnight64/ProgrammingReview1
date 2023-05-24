using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : PickUp
{
    public GameObject[] sneks;

    public override void Activate()
    {
        sneks = GameObject.FindGameObjectsWithTag("Enemy");

      foreach (GameObject enemy in sneks)
        {
            enemy.GetComponent<Enemy>().speed = 0;

        }

        StartCoroutine(Speedset());
    }

    IEnumerator Speedset()
    {
        yield return new WaitForSeconds(3);

        foreach (GameObject enemy in sneks)
        {
            enemy.GetComponent<Enemy>().speed = 3;

           
        }
    }
}
