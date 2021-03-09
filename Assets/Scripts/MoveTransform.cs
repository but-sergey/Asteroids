using UnityEngine;


namespace Asteroids
{
    internal sealed class MoveTransform
    {
        private readonly Transform _transform;
        private readonly float _speed;
        private Vector3 _move;

        public MoveTransform(Transform transform, float speed)
        {
            _transform = transform;
            _speed = speed;
        }

        public void Move(Vector3 baseMove, float deltaTime)
        {
            var speed = deltaTime * _speed;
            _move.Set(baseMove.x * speed, baseMove.y * speed, baseMove.z * speed);
            _transform.localPosition += _move;
        }
    }
}
