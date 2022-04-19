using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableController : MonoBehaviour
{
    private int cherriesCount = 0;
    [SerializeField] private Text countText;
    [SerializeField] private float destroyDelay = 0.5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            cherriesCount++;
            countText.text = $"Cherries: {cherriesCount}";
            StartCoroutine(DestroyItem(collision));
        }
    }

    private IEnumerator DestroyItem(Collider2D collision)
    {
        yield return new WaitForSeconds(destroyDelay);
        Destroy(collision.gameObject);
    }
}
