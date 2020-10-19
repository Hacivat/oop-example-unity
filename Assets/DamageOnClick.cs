using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnClick : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            //sahnedeki Damagable'dan kalıtım almış tüm objelere hasar verir
            //var damagebles = FindObjectsOfType<Damagable>();
            //foreach (var damagable in damagebles)
            //{
            //    damagable.TakeDamage(1);
            //}
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                ITakeDamage damagable = hitInfo.collider.GetComponent<ITakeDamage>();
                if (damagable != null)
                {
                    damagable.TakeDamage(1);
                }
            }
        }
    }
}
