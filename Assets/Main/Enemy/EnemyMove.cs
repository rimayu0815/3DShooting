using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private CharacterController enemyController;

    private Animator animator;

    private Vector3 destination;

    [SerializeField]
    private float walkSpeed = 1.0f;

    private Vector3 velocity;

    private Vector3 direction;

    private bool arrived = false;

    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        enemyController = GetComponent<CharacterController>();

        animator = GetComponent<Animator>();

        startPosition = transform.position;

        Vector2 randDestination = Random.insideUnitCircle * 8;
        destination = startPosition + new Vector3(randDestination.x,0,randDestination.y);

        velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyController.isGrounded)
        {
            velocity = Vector3.zero;

            animator.SetFloat("Speed", 2.0f);

            direction = (destination - transform.position).normalized;

            transform.LookAt(new Vector3(destination.x, transform.position.y, destination.z));

            velocity = direction * walkSpeed;

            Debug.Log(destination);
        }

        velocity.y += Physics.gravity.y * Time.deltaTime;
        enemyController.Move(velocity * Time.deltaTime);

        if(Vector3.Distance(transform.position,new Vector3(destination.x,transform.position.y,destination.z))<0.5f)
        {
            arrived = true;
            animator.SetFloat("Speed", 0.0f);
        }
    }
}
