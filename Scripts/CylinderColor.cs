using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CylinderColor : MonoBehaviour
{
    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
         _meshRenderer.material.DOColor(Color.red,2).SetLoops(-1, LoopType.Yoyo);
    }   
}
