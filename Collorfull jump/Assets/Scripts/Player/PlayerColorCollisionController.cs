using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerColorCollisionController : MonoBehaviour
{
    [SerializeField] ColorManager colorStore;
    [SerializeField] ColorDisplayer displayer;
    [SerializeField] AudioSource pickUpSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectble")
        {
            var collectble = collision.GetComponent<CollectbleColor>();
            if (colorStore.CurrentColor() == collectble.Color)
            {
                colorStore.RemoveCurrentColor();
                displayer.UpdateUI();
                Destroy(collision.gameObject);
                pickUpSound.Play();
            }
            else
            {
                SceneManager.LoadScene("GameOver");              
            }
        }
    }
}
