using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMove : MonoBehaviour {

    Transform player;               //player's position.
    NavMeshAgent nav;               //nav mesh agent.

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Playuh").transform;      //for some reason didnt let me add the tag "Player", had to use Playuh instead haha
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        nav.SetDestination(player.position);
    }

    /*  this code was faulty
    private NavMeshAgent theAgent;
    public Transform target;

	void Start () {
        theAgent = GetComponent<NavMeshAgent>();
	}

    void Update() {
        theAgent.SetDestination(target.position);    
    }
    */

}
