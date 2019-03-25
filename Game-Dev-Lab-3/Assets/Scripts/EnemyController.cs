using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent agent1, agent2, agent3, agent4, agent5;
    GameObject[] chairs;
    GameObject tar1, tar2, tar3, tar4, tar5;

    // Start is called before the first frame update
    void Start()
    {
        chairs = GameObject.FindGameObjectsWithTag("chair");

        tar1 = chairs[0];
        tar2 = chairs[1];
        tar3 = chairs[2];
        tar4 = chairs[3];
        tar5 = chairs[4];

        agent1.SetDestination(tar1.transform.position);
        agent2.SetDestination(tar2.transform.position);
        agent3.SetDestination(tar3.transform.position);
        agent4.SetDestination(tar4.transform.position);
        agent5.SetDestination(tar5.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
