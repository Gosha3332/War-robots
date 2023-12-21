using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public int kill;
    [SerializeField] private GameObject win;
    
    void Start()
    {
        StartCoroutine(pobeda());
    }
    private IEnumerator pobeda()
    {

        while (true)
        {
            yield return new WaitForSeconds(5f);
            if (kill >= 7)
            {
                win.SetActive(true);
                Time.timeScale = 0;
            }
        }
    } 
    public void killed()
    {
        kill++;
    }
}
