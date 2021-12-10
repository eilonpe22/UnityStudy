using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damgeables : MonoBehaviour
{
    [SerializeField] float maxHealth = 100f;
    float currentHealth;



        private void Awake()
    {
        currentHealth = maxHealth;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        print(name + "was destroy");
        Destroy(this.gameObject);

    }
}
