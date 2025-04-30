using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esqueleto : BaseEnemy
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
        print("Enemigo recibido" + (_damage * 2));
    }
    public override void RecibirAtaque(int _damage, string tipoAtaque)
    {
        //  base.RecibirAtaque(_damage, tipoAtaque);
        print("Enemigo recibido" + (_damage * 2) + "De tipo " + tipoAtaque);
    }
}
