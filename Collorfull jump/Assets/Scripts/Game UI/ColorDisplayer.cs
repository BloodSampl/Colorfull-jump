using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorDisplayer : MonoBehaviour
{
    [SerializeField] Image colorPrefab;
    [SerializeField] ColorManager colorManager;
    List<Image> createdImages =new List<Image>();


    private void Start()
    {
        AssignColorsToShapes();
    }
     void AssignColorsToShapes()
    {
        var colorList = colorManager.GetColorList();
        foreach (var color in colorList)
        {
            var image = Instantiate(colorPrefab, transform);
            image.color = colorManager.GetColor(color);
            createdImages.Add(image);
        }
    }
    public void UpdateUI()
    {
        foreach (var image in createdImages)
        {
            Destroy(image.gameObject);
        }
        createdImages.Clear();
        AssignColorsToShapes();
    }

}
