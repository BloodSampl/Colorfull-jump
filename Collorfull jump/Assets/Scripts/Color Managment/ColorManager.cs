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
            _ => Color.black
        };
    }
}
