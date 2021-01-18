using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public Slider healthBar;
    public void TakeDamage(int healthLost)
    {
        health = health - healthLost;
        healthBar.value = health / 100f;
    }
}
