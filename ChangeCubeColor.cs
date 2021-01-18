using UnityEngine;
using UnityEngine.UI;

public class ChangeCubeColor : MonoBehaviour
{
    public Image img;
    MeshRenderer cube;

    private void Update()
    {
        Ray ray;
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(img.transform.position);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                cube = hit.collider.GetComponent<MeshRenderer>();
                cube.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            }
        }
    }
}


