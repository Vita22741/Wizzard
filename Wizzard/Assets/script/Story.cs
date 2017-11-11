using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Story : MonoBehaviour {
	enum States
	{
		kidnape,
		death,
		totrture,
		badEnd,
		goodEnd
	}
	States state= States.kidnape;

	public Text mainText;	
	// Update is called once per frame
	void Update ()
	{
		if (state == States.kidnape) {
			Kidnap ();
		}
		if (state == States.death) {
			Death ();
		}
	}
	void Kidnap()
	{
		mainText.text = " Ты банкир как то раз тебя схватили и закинули в багажник, тебе угражают что убьют твоих родствеников если ты не скажешь им где лежат деньги\n"
		+ "(П)Сказать где деньги\n (Н)Ничего не делать\n (Е)Попытатся сбежать\n";
		if (Input.GetKeyDown (KeyCode.G)) {
			state = States.death;
		}
		if (Input.GetKeyDown (KeyCode.Y)) {
			state = States.totrture;
		}
		if (Input.GetKeyDown (KeyCode.T)) {
			state = States.death;
		}
	}

	void Death()
	{
		mainText.text = "Вы сказали где деньги, вас убили и забрали деньги а ваша семья стала бедной и умерла от голода\n"
			+ "(З)Вернутся назад";
		if (Input.GetKeyDown (KeyCode.P))
		{
				state = States.kidnape;
		}
	}
 }