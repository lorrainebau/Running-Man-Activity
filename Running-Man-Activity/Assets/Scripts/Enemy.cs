using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject target; //player
    UnityEngine.AI.NavMeshAgent agent; // enemy
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        if(target == null)
            target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //this is for updating the target
        agent.destination = target.transform.position;
    }
    //function for catch player
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        SceneManager.LoadScene("SampleScene");
    }
}
