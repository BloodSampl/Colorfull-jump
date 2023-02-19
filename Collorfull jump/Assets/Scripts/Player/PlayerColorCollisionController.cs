using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerColorCollisionController : MonoBehaviour
{
    [SerializeField] ColorManager colorStore;
    [SerializeField] ColorDisplayer displayer;
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
            }
            else
            {
                SceneManager.LoadScene("GameOver");              
            }
        }
    }
}
