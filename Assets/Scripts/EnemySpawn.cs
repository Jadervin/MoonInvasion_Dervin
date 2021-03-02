using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawn : MonoBehaviour
{
    public Transform spawnPosition;
    //float minSpawnSec = 2, maxSpawnSec = 10;
   
    public GameObject enemyPrefab;

    public Transform player;
    public float spawnEverySeconds;
    float secPassed = 0;


    // Start is called before the first frame update
    private void Start()
    {
        //spawnEverySeconds = Random.Range(minSpawnSec, maxSpawnSec);
    }

    // Update is called once per frame
    void Update()
    {
        secPassed += Time.deltaTime;

        if(secPassed>spawnEverySeconds)
        {
            secPassed = 0;

            //spawnEverySeconds = Random.Range(minSpawnSec, maxSpawnSec);
            GameObject temp=Instantiate(enemyPrefab, spawnPosition.position, enemyPrefab.transform.rotation);
            /*
            NavMeshAgent tempAgent;

            if(temp.TryGetComponent<NavMeshAgent>(out tempAgent))
            {
                tempAgent.SetDestination(player.position);
            }

            */
        }
    }
}
