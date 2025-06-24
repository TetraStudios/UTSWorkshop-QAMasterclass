using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinBox : MonoBehaviour
{
    [SerializeField] private GameObject winUI;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(StartGameOver());
        }
    }

    IEnumerator StartGameOver()
    {
        GameObject newUI = Instantiate(winUI, transform.position, Quaternion.identity);
        
        yield return new WaitForSeconds(5f);
        
        //Restart Level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
