using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public GameObject sheep;
    public NavMeshAgent enemy;
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            die();
        }
    }

    void Start()
    {
        enemy.SetDestination(sheep.transform.position);
    }

    public void die()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene("Lose");
    }

}
