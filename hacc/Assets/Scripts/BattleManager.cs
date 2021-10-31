using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{

    private GameObject player;
    private GameObject enemy;

    public void SetDamage(string caster, int target, int damage)
    {
        if (caster.Equals("player"))
        {
            enemy.transform.GetChild(target).GetComponentInChildren<Slider>().value -= damage;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
