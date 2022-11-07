using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class StopOnTargetHit : MonoBehaviour
{

    public GameObject trowingDart;
    Rigidbody trowingDartRigidbody;
    XRGrabInteractable trowingDartXRGrabInteractable;

    bool hit = false;

    // Start is called before the first frame update
    void Start()
    {
        trowingDartRigidbody = trowingDart.GetComponent<Rigidbody>();
        trowingDartXRGrabInteractable = 
          trowingDart.GetComponent<XRGrabInteractable>();
    }

    void FixedUpdate()
    {
        if(this.transform.position.z >= 0 && !hit)
        {
          Debug.Log(new Vector2(this.transform.position.x, this.transform.position.y));
          hit = true;
          trowingDartRigidbody.velocity = Vector3.zero;
          Destroy(trowingDartXRGrabInteractable);
          Destroy(trowingDartRigidbody);
        }
    }
}
