using UnityEngine;

public class Seed : MonoBehaviour
{
    public GameObject nextUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            nextUI.SetActive(true);
        }
    }
}
