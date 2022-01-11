using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    [SerializeField] private string nextSceneName;
    [SerializeField] private bool lastLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (lastLevel == true)
            {
                Debug.Log("You win");
            }
            else
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
