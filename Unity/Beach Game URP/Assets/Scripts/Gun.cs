using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 200f;
    public Material material;

    public Camera cam;


    public void Shoot()
    {
        Debug.Log("Shoot");
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }

    }
}
