using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Goal _goalEnemy;

    public void Spawn()
    {
        Vector3 enemyPosition = transform.position;
        Quaternion enemyRotation = transform.rotation;

        Enemy enemy = Instantiate(_enemy, enemyPosition, enemyRotation);
        enemy.SetGoal(_goalEnemy);
    } 
}
