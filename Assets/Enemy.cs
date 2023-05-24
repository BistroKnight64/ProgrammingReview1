using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public Vector2 TrackTarget;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TrackTarget = (Player.transform.position - gameObject.transform.position).normalized;
        transform.Translate(TrackTarget * speed * Time.deltaTime);
    }
}
