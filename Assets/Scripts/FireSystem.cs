using UnityEngine;


namespace Asteroids
{
    internal sealed class FireSystem : MonoBehaviour
    {
        private readonly Rigidbody2D _bullet;
        private readonly Transform _barrel;

        public FireSystem(Rigidbody2D bullet, Transform barrel)
        {
            _bullet = bullet;
            _barrel = barrel;
        }

        public void Fire(float force)
        {
            var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * force);
        }
    }
}
