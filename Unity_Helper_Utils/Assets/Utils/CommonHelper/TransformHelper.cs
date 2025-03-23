using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using Utils.Extensions;

public static partial class CommonHelper
{
    /// <summary>
    /// 将Transform 子节点全部移动到另一个节点下
    /// Move all child nodes to another node
    /// </summary>
    private static void MoveAllChildren(Transform oldParent, Transform newParent)
    {
        if (oldParent == null || newParent == null) return;

        var tempList = ObjectPool.Instance.Get<List<Transform>>();
        tempList.Clear();

        for (int i = 0; i < oldParent.childCount; i++)
        {
            tempList.Add(oldParent.GetChild(i));
        }

        foreach (var child in tempList)
        {
            child.SetParent(newParent);
            child.localPosition = Vector3.zero;
        }

        tempList.Clear();
        tempList.RecycleToPool();
    }
}
