using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;

    public GameObject character;

    public GameObject player;

    private void Start()
    {
        agent.updateRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.transform.position += agent.desiredVelocity * Time.deltaTime;
        }
        else
        {
            character.transform.position += new Vector3(0f, 0f, 0f);
        }
    }
}
