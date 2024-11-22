using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WidthCamera : MonoBehaviour
{
    private float _startAspect = 1600f / 900f;
    private float _defaultHeight, _defaultWidth;
    public CanvasScaler[] Canvas = new CanvasScaler[] { };

    private void Awake()
    {
        for (int i = 0; i < Canvas.Length; i++)
        {
            Canvas[i].matchWidthOrHeight = 1f;
        }
        if (Camera.main.aspect < _startAspect)
        {
            for (int i = 0; i < Canvas.Length; i++)
            {
                Canvas[i].matchWidthOrHeight = 0f;
            }
            _defaultHeight = Camera.main.orthographicSize;
            _defaultWidth = Camera.main.orthographicSize * _startAspect;

            Camera.main.orthographicSize = _defaultWidth / Camera.main.aspect;
        }
    }
}
