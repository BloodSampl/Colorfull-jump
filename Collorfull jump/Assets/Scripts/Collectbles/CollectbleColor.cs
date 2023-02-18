using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectbleColor : MonoBehaviour
{
    [SerializeField] GamePlayColors color;
    [SerializeField] ColorManager colorManager;
    SpriteRenderer renderer;
    public GamePlayColors Color => color; // to access it in the collision

    private void Awake()
    {
        colorManager = FindObjectOfType<ColorManager>();
    }
    private void Start()
    {
        renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.color = colorManager.GetColor(GetPrefabRandomColor());
    }
    private GamePlayColors GetPrefabRandomColor()
    { return color = colorManager.GetRandomColor(); }
}
