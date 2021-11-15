using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public float damage = 20f;
    public float range = 300f;

    public Image box;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public ParticleSystem muzzleFlash2;
    public RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay (fpsCam.transform.position, fpsCam.transform.forward * 300, Color.green);
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)  && hit.collider.tag == "Enemy")
        {
            Shoot();
            box.GetComponent<Image>().color = new Color32(255,0,0,100);
        }
        else
        {
            box.GetComponent<Image>().color = new Color32(255,255,255,100);
        }
    }
    void Shoot()
    {
        muzzleFlash.Play();
        muzzleFlash2.Play();

        EnemyController enemyController = hit.transform.GetComponent<EnemyController>();

        if(enemyController != null)
        {
            enemyController.TakeDamage(damage);
        }
    }
    /*private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(fpsCam.transform.position, fpsCam.transform.forward * 300f);
    }*/
}
