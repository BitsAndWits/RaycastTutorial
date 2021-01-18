using UnityEngine;
using UnityEngine.UI;

public class PlayRadio : MonoBehaviour
{
    public Image img;
    AudioSource radio;

    private void Update()
    {
        Ray ray;
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(img.transform.position);
            if (Physics.Raycast(ray, out hit, 100f))
            {
                radio = hit.collider.GetComponent<AudioSource>();
                if (radio.isPlaying)
                {
                    radio.Pause();
                } else
                {
                    radio.Play();
                }
            }
        }
    }
}
