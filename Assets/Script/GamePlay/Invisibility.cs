using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Invisibility : MonoBehaviour
{
    [SerializeField] private Material clasicMaterial = null;
    [SerializeField] private Material ghostMaterial = null;
    [SerializeField] private bool isDarkEnv = false;
    [SerializeField] private bool isGhost = false;

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
        if (_meshRenderer == null)
            return;

        if (isDarkEnv)
        {
            if (isGhost)
                _meshRenderer.enabled = false;
            else
                _meshRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
        }
        else
        {
            _meshRenderer.enabled = true;
            _meshRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        }
    }

    public void ToDark(bool active = true)
    {
        isDarkEnv = active;
    }

    public void SetGhost(bool ghost = true)
    {
        isGhost = ghost;
    }

}
