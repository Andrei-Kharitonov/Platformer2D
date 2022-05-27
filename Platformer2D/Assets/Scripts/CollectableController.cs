using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableController : MonoBehaviour
{
    public int cherriesCount = 0;
    [SerializeField] private Text countText;
    [SerializeField] private float destroyDelay = 0.5f;

    private void Start()
    {
        cherriesCount = PlayerPrefs.GetInt("cherriesCount");
        countText.text = $"Cherries: {cherriesCount}";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            cherriesCount++;
            countText.text = $"Cherries: {cherriesCount}";
            PlayerPrefs.SetInt("cherriesCount", cherriesCount);
            StartCoroutine(DestroyItem(collision));
        }
    }

    private IEnumerator DestroyItem(Collider2D collision)
    {
        yield return new WaitForSeconds(destroyDelay);
        Destroy(collision.gameObject);
    }
}
