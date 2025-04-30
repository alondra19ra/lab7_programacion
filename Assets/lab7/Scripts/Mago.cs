using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago :  BaseEnemy
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void Set(string _name, int _hp)
    {
        base.Set(_name, _hp);
    }
    public override void RecibirAtaque(int _damage)
    {
        //base.RecibirAtaque(_damage);
        print("Enemigo recibido" + (_damage * 4));
    }
    public override void RecibirAtaque(int _damage, string tipoAtaque)
    {
        //  base.RecibirAtaque(_damage, tipoAtaque);
        print("Enemigo recibido" + (_damage * 4) + "De tipo " + tipoAtaque);
    }
}
