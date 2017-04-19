﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class Lizard : MonoBehaviour
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

        Debug.Log("Attacking!");
        animator.SetBool("isAttacking", true);
        attacker.Attack(obj);
    }
}