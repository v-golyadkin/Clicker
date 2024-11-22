using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootstrapEntryPoint : MonoBehaviour
{
    private IEnumerator Start() // Начальная точка входа в приложение
    {
        var loadingDuration = 2f;

        while(loadingDuration > 0)
        {
            loadingDuration -= Time.deltaTime;
            Debug.Log("Loading");               // 2 секундная загрузка
            yield return null;
        }

        SceneManager.LoadScene("MenuScene"); 
    }
}
