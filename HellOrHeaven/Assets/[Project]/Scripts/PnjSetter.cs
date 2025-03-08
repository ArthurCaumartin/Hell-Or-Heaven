using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PnjSetter : MonoBehaviour
{
    [SerializeField] private PnjData _pnjData;

    [Header("Pivots :")]
    [SerializeField] private SpriteRenderer[] _eyesRenderer;
    [SerializeField] private SpriteRenderer _mouthRenderer;
    [SerializeField] private SpriteRenderer _hairRenderer;
    [SerializeField] private SpriteRenderer _bodyRenderer;


    private void Start()
    {
        SetVisual();
    }


    private void SetVisual()
    {
        foreach (var item in _eyesRenderer)
            item.sprite = _pnjData.eyesSprites.GetRandom();

        _mouthRenderer.sprite = _pnjData.mouthsSprites.GetRandom();
        _hairRenderer.sprite = _pnjData.hairSprites.GetRandom();
        _bodyRenderer.sprite = _pnjData.bodysSprites.GetRandom();
    }
}