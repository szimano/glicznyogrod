using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Damage(float damage)
    {
        health -= damage;

        if (health <= 0f)
        {
            Debug.Log(gameObject + " died!");
            Destroy(gameObject);
        }
    }
}