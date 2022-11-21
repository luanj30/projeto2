using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityTemplateProjects;

public class EnemyController : MonoBehaviour
{
    public EnemyDataSO enemyData;
   
        
    private float _moveSpeed;

    private int _maxHealthPoints;
        
    private GameObject _enemyMesh;
    
    public float ReturnDistance  => _returnDistance;
    public float _returnDistance;
    
    
    public float AttackDistance => _attackDistance;
    public float _attackDistance;
    
    public float FollowDistance => _followDistance;
    public float _followDistance;
    
    public float GiveUpDitance =>_giveUpDistance;
    public float _giveUpDistance;

    private int _currentHealthPoints;

    private float _currentMoveSpeed;

    private Animator _enemyFSM;
    private NavMeshAgent _navMeshAgent;

    private SphereCollider _sphereCollider;

    public PatrolRoute myPatrolRoute;

    private void Awake()
    {
        _moveSpeed = enemyData.moveSpeed;
        _maxHealthPoints = enemyData.maxHealthPoints;

       //enemyMesh = Instantiate(enemyData.enemyMesh, transform);

        _followDistance = enemyData.followDistance;
        _returnDistance = enemyData.returnDistance;
        _attackDistance = enemyData.attackDistance;
        _giveUpDistance = enemyData.giveUpDistance;

        _currentHealthPoints = _maxHealthPoints;
        _currentMoveSpeed = _moveSpeed;

        _enemyFSM = GetComponent<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _sphereCollider = GetComponent<SphereCollider>();
    }

    public void SetSphereRadius(float value)
    {
        _sphereCollider.radius = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(message:"jogador entrou na area");
        }
    }
}

