using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldie 
{
    private int health;
    private int damage;
    private float speed;
	private float spendings;

    public Soldie(int health, int damage, float speed, float spendings)
    {
        this.health = health;
        this.damage = damage;
        this.speed = speed;
		this.spendings = spendings;
    }
}
