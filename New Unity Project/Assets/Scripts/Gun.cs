using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    Transform cam;
    [SerializeField] float Range = 50f;
    [SerializeField] float damage = 10f;


    private void Awake()
    {
        cam = Camera.main.transform;
    }

    public void Shot()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.position, cam.forward, out hit, Range))
        {
            if(hit.collider.GetComponent<Damgeables>() != null)
            {
                hit.collider.GetComponent<Damgeables>().TakeDamage(damage);
                Debug.Log("Hit");
            }
           
        }
    }

}
