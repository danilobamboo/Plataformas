using UnityEngine;

public class CollectableCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    private void Start() => UpdateCount();

    private void OnEnable() => Collectable.OnCollected += OnCollectableCollected;
    private void OnDisable() => Collectable.OnCollected -= OnCollectableCollected;

    void OnCollectableCollected()
    {
        count++;
        UpdateCount(); 
    }

    void UpdateCount()
    {
        text.text = $"{count}/{Collectable.total}";
    }
}
