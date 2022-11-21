using UnityEngine;

namespace UnityTemplateProjects
{
    [CreateAssetMenu(fileName = "EneData", menuName = "Assts/Enemy", order = 0)]
    public class EnemyDataSO : ScriptableObject
    {
       
        
        public float moveSpeed;

        public int maxHealthPoints;
        
        public GameObject enemyMesh;
        
        public float followDistance;
        
        public float returnDistance;
        
        public float attackDistance;
        
        public float giveUpDistance;

    }
}