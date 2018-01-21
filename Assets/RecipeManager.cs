using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public enum Ingredients {
	MagicalMushroom,
	Bone,
	BatEye,
	FenixFeather
}

public enum PowerUps {
	None,
	Speed,
	ManaRegen,
	Tenacity,
	SpellPower
}

public struct Recipe {
	string name;
	Tuple<Ingredients,int>[] ingredients; 
	int reward;
	PowerUps powerUp;

	public Recipe(
		string name,
		Tuple<Ingredients,int>[] ingredients,
		int reward,
		PowerUps powerUp = PowerUps.None
	) {
		this.name = name;
		this.ingredients = ingredients;
		this.reward = reward;
		this.powerUp = powerUp;
	}
}

public class RecipeManager : MonoBehaviour {

	public List<Recipe> recipes;

	// Use this for initialization
	void Start () {
		recipes = new List<Recipe> ();

		Tuple<Ingredients,int>[] ingredients = new Tuple<Ingredients,int>[2];
		ingredients[0] = Tuple.Create<Ingredients, int>(Ingredients.FenixFeather, 2);
		ingredients [1] = Tuple.Create<Ingredients, int> (Ingredients.Bone, 1);
		Recipe test = new Recipe (
			"Resurrection Potion",
			ingredients,
			100);

		recipes.Add (test);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
