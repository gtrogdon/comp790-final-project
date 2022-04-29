using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ScaledGrab : XRGrabInteractable
{
    private Vector3 targetScale = Vector3.zero;

    protected override void OnSelectEntering(XRBaseInteractor interactor)
    {
        base.OnSelectEntering(interactor);
        StoreInteractor(interactor);
        MoveAttachmentPoint(interactor);
    }

    private void StoreInteractor(XRBaseInteractor interactor)
    {
        targetScale = transform.localScale;
    }

    private void MoveAttachmentPoint(XRBaseInteractor interactor)
    {
        transform.localScale = Vector3.one + (transform.localScale/5);
    }

    protected override void OnSelectExiting(XRBaseInteractor interactor)
    {
        base.OnSelectExiting(interactor);
        ResetAttachmentPoint(interactor);
        ClearInteractor(interactor);
    }

    private void ResetAttachmentPoint(XRBaseInteractor interactor)
    {
        transform.localScale = targetScale;
    }

    private void ClearInteractor(XRBaseInteractor interactor)
    {
        targetScale = Vector3.zero;
    }
}
