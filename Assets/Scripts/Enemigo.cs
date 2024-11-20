using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;

    private Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        playerTransform = FindAnyObjectByType<Jugador>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = playerTransform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
