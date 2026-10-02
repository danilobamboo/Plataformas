using UnityEngine;
using TMPro;

[RequireComponent(typeof(BoxCollider))]
public class WinZone : MonoBehaviour
{
    [SerializeField] private TMP_Text winText;                        
    [SerializeField, TextArea] private string message = "¡Ganaste!";  
    [SerializeField] private bool pauseGame = true;                   

    private void Start() => winText.gameObject.SetActive(false);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerObj")) ShowWin();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("PlayerObj")) ShowWin();
    }

    private void ShowWin()
    {
        winText.text = message;
        winText.gameObject.SetActive(true);
        if (pauseGame) Time.timeScale = 0f;
    }
}