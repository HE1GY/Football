using UnityEngine;

namespace CodeBase
{
    public abstract class CreatureMove:MonoBehaviour
    {
        private const float ZMaxBound=1.5f;
        private const float ZMinBound=-1.5f;
        
        [SerializeField] protected float _speed;
        
        protected Vector3 GetClampedZVector()
        {
            var zClamped = Mathf.Clamp(transform.position.z, ZMinBound, ZMaxBound);
            return new Vector3(transform.position.x, transform.position.y, zClamped);
        }
        protected abstract void  Move();
    }
}