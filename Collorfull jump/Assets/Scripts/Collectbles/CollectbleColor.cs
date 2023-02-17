using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectbleColor : MonoBehaviour
{
    [SerializeField] GamePlayColors color;
    [SerializeField] ColorManager colorManager;
    SpriteRenderer renderer;
    public GamePlayColors Color => color;

    private void Start()
    {
        renderer= gameObject.GetComponent<SpriteRenderer>();
        renderer.color = colorManager.GetColor(color);
    }
}
