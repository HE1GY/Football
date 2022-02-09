using System;
using CodeBase.GameLogic.Ball;
using UnityEngine;
using Random = UnityEngine.Random;

namespace CodeBase.AI
{
    public class EnemyMove : CreatureMove
    {
        [SerializeField] private BallMovement _ballMovement;

        private void Update()
        {
            if (_ballMovement.Direction.x > 0)
            {
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
