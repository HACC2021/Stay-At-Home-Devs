using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour
{

    public BattleManager battle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void move1() 
    {
        StartCoroutine("attack");
        battle.SetDamage("player", 1, 1);
    }

    public void move2()
    {
        StartCoroutine("attack");
    }

    public void move3()
    {
        StartCoroutine("attack");
    }

    public IEnumerator attack()
    {
        transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        yield return new WaitForSeconds(0.5f);
        transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        yield return null;
    }
}
