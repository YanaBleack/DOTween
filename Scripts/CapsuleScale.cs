using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CapsuleScale : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(new Vector3(2, 2, 2), 2).SetLoops(-1, LoopType.Yoyo);
    }
}
