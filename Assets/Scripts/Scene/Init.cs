using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scene
{
    public class Init : MonoBehaviour
    {
        public void Start()
        {
            SceneManager.LoadScene("Main");
        }
    }
}