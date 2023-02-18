using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    [SerializeField] List<GamePlayColors> colors;

    public List<GamePlayColors> GetColorList()
    {
        return colors;
    }
    public GamePlayColors CurrentColor()
    { return colors[0]; } 

    public void RemoveCurrentColor()
    {
        colors.RemoveAt(0);
    }
    public Color GetColor(GamePlayColors color)
    {
        return color switch
        {
            GamePlayColors.Blue => Color.blue,
            GamePlayColors.Green => Color.green,
            GamePlayColors.Red => Color.red,
            GamePlayColors.Yellow => Color.yellow,
            GamePlayColors.Purple => new Color(0.56f, 0.04f, 1f),
            GamePlayColors.Orange => new Color(1f, 0.59f, 0f),
            _ => Color.black
        };
    }
    public GamePlayColors GetRandomColor()
    {
        if(colors.Count == 0) 
        {         
            return GamePlayColors.Blue;
        }
        int randomIndex = UnityEngine.Random.Range(0, colors.Count);
        return colors[randomIndex];
    }

}
