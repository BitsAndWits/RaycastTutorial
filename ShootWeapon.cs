using UnityEngine;
using UnityEngine.UI;

public class ShootWeapon : MonoBehaviour
{
    public Image img;
    Animator animator;
    Enemy enemy;

    private void Update()
    {
        Ray ray;
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(img.transform.position);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                animator = hit.collider.GetComponent<Animator>();
                enemy = hit.collider.GetComponent<Enemy>();

                if (enemy.health == 0)
                {
                    animator.SetInteger("moving", 12);
                } else
                {
                    enemy.TakeDamage(20);
                }
            }
        }
    }
}
