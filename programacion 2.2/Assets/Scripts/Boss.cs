using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boss : MonoBehaviour
{
    public Transform[] positions;
    public int positionActual = 0;
    public float speed = 5;
    public int vidas = 5;
    public Rigidbody rb;

    public Animator anim;

    public NavMeshAgent myAgent;
    // Start is called before the first frame update
    void Start()
    {
        myAgent = this.GetComponent<NavMeshAgent>();
        anim = this.GetComponent<Animator>();
    }

   

    public void moveToNextPosition()
    {
            Vector3 posToGo = positions[Random.Range(0, positions.Length)].position;
            myAgent.SetDestination(posToGo);
        
    }

    internal void recibirDaño()
    {
        this.vidas -= 1;
        moveToNextPosition();
    }


}
