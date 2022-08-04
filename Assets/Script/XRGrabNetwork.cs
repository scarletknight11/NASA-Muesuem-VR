using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabNetwork : XRGrabInteractable {

    private PhotonView photonview;

    // Start is called before the first frame update
    void Start()
    {
        photonview = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    protected override void OnSelectEntering(XRBaseInteractor interactor)
    {
        //request ownership with current lookout of player
        photonview.RequestOwnership();
        base.OnSelectEntering(interactor);
    }
}
