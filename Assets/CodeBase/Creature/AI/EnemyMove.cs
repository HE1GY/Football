using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace CodeBase.AI
{
    public class EnemyMove : CreatureMove
    {
        private const int NumberWhenMiss=1;
        
        [SerializeField] private BallMovement _ballMovement;
        [SerializeField] private float _nearDistance;


        private void Update()
        {
            if (_ballMovement.Direction.x > 0)
            {
                var distanceBetween = Vector3.Distance(_ballMovement.transform.position, transform.position);
                if (distanceBetween < _nearDistance/*&&NumberWheneMiss==Random.Range(1,10)*/)
                {
                    Miss();
                }
                Defence();
            }
            
        }

        private void Defence()
        {
            Move();
            transform.position=base.GetClampedZVector();
        }

        private void Miss()
        {
            
        }
        

        protected override void Move()
        {
            var speedPerSec = _speed * Time.deltaTime;
            if (_ballMovement.transform.position.z > transform.position.z)
            {
                transform.Translate(-transform.forward*speedPerSec);
            }
            else if(_ballMovement.transform.position.z < transform.position.z)
            {
                transform.Translate(transform.forward*speedPerSec);
            }
        }
    }
}
