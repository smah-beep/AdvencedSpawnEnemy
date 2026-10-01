using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Animator _animator;
    private Goal _goal;

    public Enemy(Goal goal)
    {
        _goal = goal;
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();     
    }

    public void SetGoal(Goal goal)
    {
        _goal = goal;
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, _goal.transform.position) > 2)
        {
            _animator.SetBool("Walk", true);
            transform.LookAt(_goal.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, _goal.transform.position, _speed * Time.deltaTime);
        }
        else
        {
            _animator.SetBool("Walk", false);
        }
    }
}
