using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public Transform[] m_SpawnPoints;
    public GameObject m_EnemyPrefab;
    private float timer;
    [SerializeField] float waitTime = 2f;

    // Start is called before the first frame update
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > waitTime){
            SpawnNewEnemy();
            timer = 0f;
        }
    }

    void SpawnNewEnemy() {

        int randomNumber = Mathf.RoundToInt(Random.Range(0f, m_SpawnPoints.Length-1));

        Instantiate(m_EnemyPrefab, m_SpawnPoints[randomNumber].transform.position, Quaternion.identity);


    }
}
