using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : BaseEnemy
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Set(string _name , int _hp)
    {
        base.Set(_name, _hp);
    }
    public override void RecibirAtaque(int _damage)
    {
        //base.RecibirAtaque(_damage);
        print("Enemigo recibido" + (_damage / 3));
    }
    public override void RecibirAtaque(int _damage, string tipoAtaque)
    {
        //  base.RecibirAtaque(_damage, tipoAtaque);
        print("Enemigo recibido" + (_damage / 3) + "De tipo " + tipoAtaque);
    }
}
