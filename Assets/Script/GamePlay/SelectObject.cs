using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectObject : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    private Animator _animator = null;
    private Invisibility _invisibility = null;
    [SerializeField] private GManager gManager = null;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _invisibility = GetComponent<Invisibility>();
    }

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        print("MouseEnter to " + gameObject.name);
        if (_animator && _invisibility && !_invisibility.IsDarkEnv)
            _animator.SetBool("scale", true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        print("MouseExit to " + gameObject.name);
        if (_animator && _invisibility && !_invisibility.IsDarkEnv)
            _animator.SetBool("scale", false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        print("MouseDown to " + gameObject.name);
        if (_animator && _invisibility && !_invisibility.IsDarkEnv)
            _animator.SetBool("scale", false);
        if (_invisibility && gManager)
            gManager.endOfGame(_invisibility.IsGhost);
    }
}
