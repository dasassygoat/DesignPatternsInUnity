using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private float fullHealth = 100f;
    [SerializeField] private float drainPerSecond = 2f;

    private float currentHealth = 0f;

    private void Awake()
    {
        ResetHealth();
        StartCoroutine(HealthDrain());
    }

    public float GetHealth()
    {
        return currentHealth;
    }

    public IEnumerator HealthDrain()
    {
        while (currentHealth > 0)
        {
            currentHealth -= drainPerSecond;
            yield return new WaitForSeconds(1f);
        }
    }

    public void ResetHealth()
    {
        Debug.Log("Reset Health");
        currentHealth = fullHealth;
    }
}