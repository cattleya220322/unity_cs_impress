using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var hero = new Character();
        //Debug.Log($"Hero: {hero.name_} - {hero.exp_} EXP");
        hero.PrintStatsInfo();

        var heroine = new Character("yuriebihara");
        //Debug.Log($"Heroine: {heroine.name_} - {heroine.exp_} EXP");
        heroine.PrintStatsInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
