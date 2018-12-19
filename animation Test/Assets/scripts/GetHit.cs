using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetHit : MonoBehaviour
{

    public static int health = 100;
    public Slider healthbar;
    Animator anim;
    public string opponent;


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag != opponent) return;
        healthbar.value -= 20;
        if (healthbar.value <= 0)
        { 
            anim.SetBool("isDead", true);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}