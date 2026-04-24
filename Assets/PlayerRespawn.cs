using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public float deathY = -10;

     void Update()
    {
        if (transform.position.y < deathY) 
        {
            Respawn();
        }    
    }
    void Respawn() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
