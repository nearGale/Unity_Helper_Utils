using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class CommonHelper
{
    public static string prefabUiTip = "UITip";

    /// <summary>
    /// 在鼠标位置生成 ui tip
    /// </summary>
    /// <param name="text"></param>
    public static void ShowUITipAtMouse(Canvas canvas, RectTransform canvasRectTr, Transform parent, 
        string text, int offsetX = 100, int offsetY = 50)
    {
        var screenPos = Input.mousePosition + new Vector3(offsetX, offsetY, 0);
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvasRectTr,
            screenPos,
            canvas.worldCamera,
            out var uiOffest))
        {
            ShowUITipAtScreenPos(parent, uiOffest, text);
        }
    }

    /// <summary>
    /// 在场景中物体位置生成 ui tip
    /// </summary>
    public static void ShowUITipAtGo(Canvas canvas, RectTransform canvasRectTr, Transform parent,
        Vector3 worldPos, string text, int uiOffsetX = 0, int uiOffsetY = 50)
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(worldPos);
        screenPos += new Vector3(uiOffsetX, uiOffsetY, 0);
        
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvasRectTr,
            screenPos,
            canvas.worldCamera,
            out var uiOffest))
        {
            ShowUITipAtScreenPos(parent, uiOffest, text);
        }
    }

    private static void ShowUITipAtScreenPos(Transform parent, Vector2 screenPos, string text)
    {
        var uiTip = Resources.Load<GameObject>(prefabUiTip);
        var goUITip = GameObject.Instantiate(uiTip, parent);

        var uiTipController = goUITip.GetComponent<UITipController>();

        uiTipController.initPos = screenPos;

        uiTipController.SetText(text);
    }
}