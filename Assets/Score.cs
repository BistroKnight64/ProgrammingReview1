using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : PickUp
{

    public override void Activate()
    {
        gm.PlayScore++;
    }
}
