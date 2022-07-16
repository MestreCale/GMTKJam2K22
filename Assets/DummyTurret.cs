using System;
using System.Collections;
using System.Collections.Generic;
using DM.Interfaces;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.Rendering;



public interface ITurret
{
    void Activate();
    void Deactivate();
}

[RequireComponent(typeof(Renderer)),RequireComponent(typeof(Collider))]
public class DummyTurret : MonoBehaviour , IPlaceable, ITurret
{
    private Renderer _renderer;
    private Rigidbody _rigidbody;
    private Collider _collider;


    public void Activate()
    {
        _collider.isTrigger = false;
        Destroy(_rigidbody);
     
    }

    public void Deactivate()
    {
        _collider.isTrigger = true;
    }

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _rigidbody = GetComponent<Rigidbody>();
        _collider = GetComponent<Collider>();
    }

    private void Start()
    {
        canPlace = true;
    }

    public void StartPlacing(Vector3 position)
    {
        Deactivate();
        transform.rotation = Quaternion.identity;
        gameObject.SetActive(true);
        transform.position = position;

    }

    private bool canPlace;

    private void OnTriggerEnter(Collider other)
    {
        canPlace = false;
    }

    private void OnTriggerExit(Collider other)
    {

        canPlace = true;
    }

  

    public void EndPlacing()
    {
        gameObject.SetActive(false);
    }

    public void Place()
    {
       
        if (canPlace)
        {
           Instantiate(gameObject, transform.position, transform.rotation).GetComponent<ITurret>().Activate();
        }
      
    }
}
