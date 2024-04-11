using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Enemy))]
public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    void Start(){
        var agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = target.position;
    }
    // private int wavepointIndex = 0;

    // private Enemy enemy;

    // void Start(){
    //     enemy = GetComponent<Enemy>();
    //     target = Waypoints.points[wavepointIndex];
    // }

    // void Update(){
    //     Vector3 dir = target.position - transform.position;
    //     transform.Translate(dir.normalized * enemy.speed  * Time.deltaTime, Space.World);

    //     if(Vector3.Distance(transform.position, target.position) <= 0.2f){
    //         GetNextWaypoint();
    //     }
    //     enemy.speed = enemy.startSpeed; 
    // }

    // void GetNextWaypoint(){
    //     if(wavepointIndex >= Waypoints.points.Length - 1){
    //         EndPath();
    //         return;
    //     }
    //     wavepointIndex++;
    //     target = Waypoints.points[wavepointIndex];
    // }

    public void EndPath(GameObject enemy){
        PlayerStats.Lives--;
        WaveSpawner.EnemiesAlive--;
        Destroy(enemy);
    }
}
