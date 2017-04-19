using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class Fox : MonoBehaviour
{
    private Animator animator;
    private Attacker attacker;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject obj = collider.gameObject;

        Debug.Log("Fox colliding with " + obj);

        if (!obj.GetComponent<Defender>())
        {
            return;
        }

        if (obj.GetComponent<Stone>())
        {
            Debug.Log("Jumping!");
            animator.SetTrigger("jump");
        }
        else
        {
            Debug.Log("FOX Attacking!");
            animator.SetBool("isAttacking", true);
            attacker.Attack(obj);
        }
    }
}