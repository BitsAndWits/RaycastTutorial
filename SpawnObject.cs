using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{
    public Image img;
    public GameObject objectToSpawn;
    Vector3 spawnPosition;

    private void Update()
    {
        Ray ray;
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(img.transform.position);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                spawnPosition = hit.point;
            }
            Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(0f, 0f, 0f));
        }
    }
}
