using System;
using System.Collections;
using System.Collections.Generic;
using DM.Interfaces;
using UnityEngine;


[RequireComponent(typeof(Renderer))]
public class DummyObject : MonoBehaviour, ISelectable
{
    private Renderer _renderer;
    private Color _color;

    private void Awake()
    {
        
        _renderer = GetComponent<Renderer>();
       
    }

    private void Start()
    {
        
        _color = _renderer.material.color;
    }

    public void OnSelect()
    {
        
    }

    public void OnDeselect()
    {
      
    }

    public void OnHover()
    {
        _renderer.material.color = Color.red;
   
    }

    public void OnDeHover()
    {
        _renderer.material.color = _color;
    }
}
