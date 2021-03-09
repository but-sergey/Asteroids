using UnityEngine;


namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed = 1.0f;
        [SerializeField] private float _maxHp = 100.0f;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;

        private MoveTransform _moveTransform;
        private PlayerInput _playerInput;
        //private FireSystem _fireSystem;
        private HealthSystem _healthSystem;

        private void Start()
        {
            _moveTransform = new MoveTransform(transform, _speed);
            _playerInput = new PlayerInput();
            //_fireSystem = new FireSystem(_bullet, _barrel);
            _healthSystem = new HealthSystem(_maxHp);
        }

        private void Update()
        {
            var move = _playerInput.GetBaseMove();
            _moveTransform.Move(move, Time.deltaTime);

            if (_playerInput.FireInput())
            {
                Debug.Log("Fire!");
                //_fireSystem.Fire(_force);
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!_healthSystem.Hurt(other.gameObject))
                Destroy(gameObject);
        }
    }
}