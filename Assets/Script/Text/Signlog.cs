using UnityEngine;

public class Signlog : MonoBehaviour
{

    public GameObject signLog;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            signLog.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            signLog.SetActive(false);
        }
    }
}
