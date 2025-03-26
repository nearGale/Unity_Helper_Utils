using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITipController : MonoBehaviour
{
    public RectTransform rectTransform;
    public Text text;

    public Vector2 initPos;
    private float _instantiateTime;

    void Start()
    {
        rectTransform.anchoredPosition = initPos;
        _instantiateTime = Time.time;

        text.CrossFadeAlpha(0, 0.5f, true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _instantiateTime + 0.5f)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            rectTransform.position += Vector3.up * 1f;
        }
    }

    public void SetText(string text)
    {
        this.text.text = text;
    }
}
