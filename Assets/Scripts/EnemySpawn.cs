using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawn : MonoBehaviour
{
    public Transform spawnPosition;

   
    public GameObject enemyPrefab;

    public Transform player;
    public float spawnEverySeconds;
    float secPassed = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secPassed += Time.deltaTime;

        if(secPassed>spawnEverySeconds)
        {
            secPassed = 0;

            
            GameObject temp=Instantiate(enemyPrefab, spawnPosition.position, Quaternion.identity);
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
