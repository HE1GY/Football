using UnityEngine;

namespace CodeBase
{
    public class BallMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;

        public  Vector3 Direction { private set; get; }

        private Vector3 _startPosition;
        

        private void Start()
        {
            _startPosition = transform.position;
            // TODO 
            Direction =new Vector3(-1,0,0)/*GetRandomDirection()*/;
            
            GameManager.Instance.ScoreGoal += ResetPosition;
        }

        private void Update()
        {
            Move();
        }

        private void OnTriggerEnter(Collider other)
        {
            ChangeDirection(other.transform.forward);
        }

        private void Move()
        {
            transform.Translate(Direction.normalized * _speed * Time.deltaTime);
        }

        private void ChangeDirection(Vector3 surfaceNormal)
        {
            Direction = Vector3.Reflect(Direction, surfaceNormal);
        }
        
        private  Vector3 GetRandomDirection()
        {
            var randomNumb = Random.Range(1, 7);
            return new Vector3(randomNumb, 0, randomNumb);
        }

        private void ResetPosition(Creature creature)
        {
            transform.position = _startPosition;
            Direction= GetRandomDirection();
        }
        
    }
}
