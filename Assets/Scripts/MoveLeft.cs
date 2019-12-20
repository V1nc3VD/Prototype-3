using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerController playerControllerScript;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    private float speed = 30;
    //de grens waar alles despawned
    private float leftBound = -15;
    
    void Update()
    {
        //als het nog niet "gameover" is gaan objecten naar links
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        //zorgt ervoor dat alles wat links uit het scherm gaat verdwijnt
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
