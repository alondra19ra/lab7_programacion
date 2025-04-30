using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamage
{
    public void RecibirAtaque(int _damage);
}
public class BaseEnemy : MonoBehaviour ,IDamage
{
    private string enemyName;
    private int enemyLife;

    public string EnemyName => enemyName;
    public int EnemyLife => enemyLife;
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void Set(string _enemyName, int _enemyLife)
    {
        enemyName = _enemyName;
        enemyLife = _enemyLife;
    }

    public virtual void RecibirAtaque(int _damage)
    {

    }
    public virtual void RecibirAtaque(int _damage, string tipoAtaque)
    {

    }
}
