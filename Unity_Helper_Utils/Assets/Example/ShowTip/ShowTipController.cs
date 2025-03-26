using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTipController : MonoBehaviour
{
    public Canvas canvas;
    public RectTransform canvasRectTransform;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit))
            {
                
                CommonHelper.ShowUITipAtGo(canvas, canvasRectTransform, canvas.transform,
                    hit.transform.position, 
                    $"<color=#00FF00>tip:点击到物体: {hit.transform.name}</color>");
            }
            else
            {
                CommonHelper.ShowUITipAtMouse(canvas, canvasRectTransform, canvas.transform,
                    "<color=#FF0000>tip:没有点击到物体</color>");
            }

        }
    }
}
