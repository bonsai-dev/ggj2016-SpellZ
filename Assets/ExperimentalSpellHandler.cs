﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ExperimentalSpellHandler : MonoBehaviour {

	private enum SpellPress {
		SPELL_0,
		SPELL_1,
		SPELL_2,
		SPELL_3
	}

    private Text uiText;

	private List<SpellPress> spellStack = new List<SpellPress>();

	// Use this for initialization
	void Start () {
        uiText = GameObject.Find("UIStackBody").GetComponent<Text>();
        uiText.text = "Empty! Summon something";

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Spell_0")) {
			spellStack.Add(SpellPress.SPELL_0);
			print("Added spell 0 to stack. Size: " + spellStack.Count);

            uiText.text += "Spell 0 \n";
		}
		if (Input.GetButtonDown ("Spell_1")) {
			spellStack.Add(SpellPress.SPELL_1);
			print("Added spell 1 to stack. Size: " + spellStack.Count);

            uiText.text += "Spell 1 \n";
		}
		if (Input.GetButtonDown ("Spell_2")) {
			spellStack.Add(SpellPress.SPELL_2);
			print("Added spell 2 to stack. Size: " + spellStack.Count);

            uiText.text += "Spell 2 \n";
		}
		if (Input.GetButtonDown ("Spell_3")) {
			spellStack.Add(SpellPress.SPELL_3);
			print("Added spell 3 to stack. Size: " + spellStack.Count);

            uiText.text += "Spell 3 \n";
		}
	}
}
