using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateAmount;
    private void Start()
    {
        transform.DOMove(new Vector3(0, 5, 0), 2).SetLoops(-1, LoopType.Yoyo);
        transform.DOScale(new Vector3(3, 3, 3), 2).SetLoops(-1, LoopType.Yoyo);
    }

    private void Update()
    {
        transform.Rotate(_rotateAmount * Time.deltaTime);
    }
}
