using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI ammoText;

    [SerializeField] private Image healthBar;

    public void SetAmmoInfo(int ammoCount, int maxAmmoCount)
    {
        ammoText.text = $"{ammoCount} / {maxAmmoCount}";
    }

    public void SetHealthInfo(int health, int maxHeatlh)
    {
        healthText.text = $"{health} / {maxHeatlh}";
        healthBar.fillAmount = (float)health / maxHeatlh;
    }
}
