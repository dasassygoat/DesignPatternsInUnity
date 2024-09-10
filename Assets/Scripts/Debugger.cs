using System.Collections;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        Health health = GetComponent<Health>();
        Level level = GetComponent<Level>();

        while (true)
        {
            yield return new WaitForSeconds(1f);
            Debug.Log($"Exp: {level.GetExperience()}, Level: {level.GetLevel()}, Health: {health.GetHealth()}");
        }
    }

}
