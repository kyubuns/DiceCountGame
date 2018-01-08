using UnityEngine;

namespace Dice
{
    public class Dice : MonoBehaviour
    {
        public void Update()
        {
            if (transform.position.y < -10.0f) Destroy(gameObject);
        }
    }
}