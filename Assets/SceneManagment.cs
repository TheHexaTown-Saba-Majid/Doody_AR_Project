
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagment : MonoBehaviour
{
   public void sceneName(string name)
    {
        SceneManager.LoadScene(name);
    }
}
