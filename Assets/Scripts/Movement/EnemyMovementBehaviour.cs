﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AI;

//[RequireComponent(typeof(Rigidbody))]
public class EnemyMovementBehaviour : MonoBehaviour
{
    //private Rigidbody _rigidbody;
    //[Tooltip("The object the enemy will be seeking towards.")]
    [SerializeField]
    private GameObject _target;
    [Tooltip("The force that will be applied to object to move it.")]
    [SerializeField]
    private float _moveForce;
    [Tooltip("The maximum magnitude this enemy's velocity can have.")]
    [SerializeField]
    private float _maxVelocity;

    public GameObject Target
    {
        get
        {
            return _target;
        }
        set 
        {
            _target = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Get a reference to the attached rigidbody
        //_rigidbody = GetComponent<Rigidbody>();


        GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        //purpose: make a path and send the enemy on route to the destination

        //If a target hasn't been set return
        if (!_target)
            return;



        NavMeshAgent enemy = GetComponent<NavMeshAgent>();

        enemy.destination = _target.transform.position;

        //NavMeshAgent newPath = enemy.CalculatePath(_target.transform.position, enemy.path);
        //enemy.SetPath(newPath.path);

        //NavMeshPath pathToDestination = enemy.CalculatePath(enemy.destination, );
        


        //enemy.SetPath(pathToDestination);


        ////Find the direction to travel towards to reach the target
        //Vector3 moveDir = _target.transform.position - transform.position;
        ////Scale the direction by the move force
        //Vector3 moveForce = moveDir * _moveForce;
        //enemy.Move(moveForce);

        ////Add the force to the rigidbody to move the object
        //_rigidbody.AddForce(moveForce);

        ////If the velocity goes over the max magnitude, clamp it
        //if (_rigidbody.velocity.magnitude > _maxVelocity)
        //    _rigidbody.velocity = _rigidbody.velocity.normalized * _maxVelocity;
    }
}
