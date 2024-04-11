using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public EnemyMovement enemyMovement;
    
    void OnTriggerEnter(Collider collider){
        enemyMovement.EndPath(collider.gameObject);
    }
}
