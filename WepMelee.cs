using UnityEngine;
using System.Collections;

public class WepMelee : MonoBehaviour
{
        public GameObject enemy;
        
        
        public void Update (){
                Attack ();
                yield WaitForSeconds(2);
        
        }
                
        void Attack(){
                if (Input.GetButtonDown ("Fire1")){
                        Vector3 enemyDelta = (enemy.transform.position - transform.position);
                        if ( Vector3.Angle( transform.forward, enemyDelta ) < 45 )
                        {
                                if ((enemy.transform.position - transform.position).magnitude < 2) {
                                        enemy.health -= 1;
                                }
                        }
                }
        }
        




}
