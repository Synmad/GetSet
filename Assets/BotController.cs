using UnityEngine;
public class BotController : MonoBehaviour
{
    GameObject player;
    PlayerController playercontroller;

    private void Awake()
    {
        player = GameObject.Find("Player");
        playercontroller = player.GetComponent<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Hello();
        }
    }

    void Hello()
    {
        Debug.Log("Hola " + playercontroller.Name + " , ahora te llamás Luca.");
        playercontroller.Name = "Luca";
    }
}
