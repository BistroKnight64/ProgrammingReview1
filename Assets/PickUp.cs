using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUp : MonoBehaviour
{

    public SpriteRenderer Sp;
    public CircleCollider2D Cc;
    public GameManager gm;
    public Player player;
    public SpriteRenderer SR;

    private void Start()
    {
        Sp = gameObject.GetComponent<SpriteRenderer>();
        Cc = gameObject.GetComponent<CircleCollider2D>();
        gm = GameObject.Find("Game manager").GetComponent<GameManager>();
        player = GameObject.Find("Player").GetComponent<Player>();
        SR = GameObject.Find("Player").GetComponent<SpriteRenderer>();
    }

    public virtual void Activate()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Activate();
        StartCoroutine(Delayeddestroy());
    }

    IEnumerator Delayeddestroy()
    {
        Sp.enabled = false;
        Cc.enabled = false;

        yield return new WaitForSeconds(5);

        Destroy(gameObject);
    }
}
