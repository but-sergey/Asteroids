using UnityEngine;


namespace Asteroids
{
    internal sealed class HealthSystem
    {
        private readonly float _maxHp = 100.0f;
        private float _hp;

        public HealthSystem(float maxHp)
        {
            _maxHp = maxHp;
            _hp = _maxHp;
        }

        public bool Hurt(GameObject gameObject)
        {
            _hp--;
            return (_hp > 0);
        }

        public void Recover()
        {
            _hp = _maxHp;
        }
    }
}
