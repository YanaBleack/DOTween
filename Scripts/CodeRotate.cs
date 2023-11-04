using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CodeRotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateAmount;

    private void Update()
    {
        transform.Rotate(_rotateAmount * Time.deltaTime);
    }
}
