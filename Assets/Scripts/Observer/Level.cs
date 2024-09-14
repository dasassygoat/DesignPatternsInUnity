using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] int pointsPerLevel = 200;
    [SerializeField] UnityEvent onLevelUp;
    private int experiencePoints = 0;

    public event Action onLevelUpAction; // Action is basically replaces the word delagate

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(.2f);
            GainExperience(10);
        }
    }

    private void GainExperience(int points)
    {

        int level = GetLevel();
        experiencePoints += points;
        if (GetLevel() > level)
        {
            onLevelUp.Invoke();
            if (onLevelUpAction != null)
            {
                onLevelUpAction();
            }
        }
    }

    public int GetExperience()
    {
        return experiencePoints;

    }

    public int GetLevel()
    {
        return experiencePoints / pointsPerLevel;
    }
}
