using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class MeteorPistol : MonoBehaviour
{
    public ParticleSystem particles;

    public LayerMask LayerMask;
    public Transform shootSource;
    public float distance = 10;
    private bool rayActivate = false;
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartShoot());
        grabInteractable.deactivated.AddListener(x => StopShoot());
    }

    public void StartShoot()
    {
        particles.Play();
        rayActivate = true;
    }

    public void StopShoot()
    {
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        rayActivate = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(rayActivate)
            RaycastCheck();
    }

    void RaycastCheck()
    {
        RaycastHit hit;
        bool hashit = Physics.Raycast(shootSource.position, shootSource.forward, out hit, distance, LayerMask);

        if (hashit)
        {
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
        }
        
    }
}
