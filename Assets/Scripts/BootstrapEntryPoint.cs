using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootstrapEntryPoint : MonoBehaviour
{
    private IEnumerator Start()
    {
        var loadingDuration = 2f;

        while(loadingDuration > 0)
        {
            loadingDuration -= Time.deltaTime;
            Debug.Log("Loading");
            yield return null;
        }

        SceneManager.LoadScene("MenuScene");
    }
}
