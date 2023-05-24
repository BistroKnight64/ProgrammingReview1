using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float HorizInput;
    public float VertInput;
    public float Speed;
    public bool Ispowered;
    public bool Canlose;
    public Vector2 StupidC;

    public SpriteRenderer amogus;
    public Sprite Deadstuff;
    public Sprite Alivestuff;
    public GameManager Man;
    public GameObject Stuff;

    // Start is called before the first frame update
    void Start()
    {
        amogus = gameObject.GetComponent<SpriteRenderer>();
        Man = Stuff.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizInput = Input.GetAxis("Horizontal");
        VertInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * Speed * HorizInput * Time.deltaTime);
        transform.Translate(Vector2.up * Speed * VertInput * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && Ispowered == true)
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Enemy") && Ispowered == false)
        {
            Speed = 0;
            amogus.sprite = Deadstuff;
            if(Canlose == true)
            {
            Man.playLif--;
                Man.Updatelife();
                Canlose = false;
            }
            StartCoroutine(CoolDown());
        }
    }

    IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(3);

     Teleport();
        Canlose = true;
        Speed = 5;
        amogus.sprite = Alivestuff;
    }

    void Teleport()
    {
        //  Stupid
        gameObject.transform.position = new Vector2(Random.Range(6, 0), Random.Range(6, 0));
    }
}
