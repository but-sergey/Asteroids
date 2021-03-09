using UnityEngine;


namespace Asteroids
{
    internal sealed class PlayerInput
    {
        private const string HORIZONTAL_AXIS = "Horizontal";
        private const string VERTICAL_AXIS = "Vertical";
        private const string FIRE_BUTTON = "Fire1";

        public Vector3 GetBaseMove()
        {
            return new Vector3(Input.GetAxis(HORIZONTAL_AXIS), Input.GetAxis(VERTICAL_AXIS), 0.0f);
        }

        public bool FireInput()
        {
            return Input.GetButtonDown(FIRE_BUTTON);
        }
    }
}
