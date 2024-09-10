using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Level : MonoBehaviour
{
    [SerializeField] int pointsPerLevel = 200;
    [SerializeField] UnityEvent onLevelUp;
    int experiencePoints = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    IEnumerator Start()
    {
        yield return new WaitForSeconds(.2f);
        GainExperience(10);
        
    }

    private void GainExperience(int points)
    {
        int level = GetLevel();
        experiencePoints += points;
        if (GetLevel() > level)
        {
            //onLevelUp.Invoke();
            GetComponent<Health>().ResetHealth();
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
