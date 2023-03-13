using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Invisibility : MonoBehaviour
{
    [SerializeField] private bool isShasowOnly = true;

    private MeshRenderer _meshRenderer = null;

    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }


    void Update()
    {
        CheckShadowMode();
    }


    private void CheckShadowMode()
    {
        if (_meshRenderer)
            _meshRenderer.shadowCastingMode =
                isShasowOnly ? UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly : UnityEngine.Rendering.ShadowCastingMode.On;
    }

}
