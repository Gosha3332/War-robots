using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string ShowAdv();

    public static bool dead = false;


    public void loadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        if (sceneID == 0 && dead == true) { ShowAdv(); }
    }
}
