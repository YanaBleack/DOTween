using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SphereMove : MonoBehaviour
{
    private void Start()
    {
        transform.DOMove(new Vector3(5, 0, 0), 2).SetLoops(-1, LoopType.Yoyo);
    }
}
