using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boss : MonoBehaviour
{
    public Transform[] positions;
    public int positionActual = 0;
    public float speed = 5;
    public float vidas = 5;
    public Rigidbody rb;

    public NavMeshAgent myAgent;
    // Start is called before the first frame update
    void Start()
    {
        myAgent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {        
         
    }

    public void moveToNextPosition()
    {
            Vector3 posToGo = positions[Random.Range(0, positions.Length)].position;
            myAgent.SetDestination(posToGo);
        
    }


   
}
