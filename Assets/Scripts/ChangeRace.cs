using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRace : MonoBehaviour {

    //Global variables
	public Button raceButton;
    //public Button hairChange;
    public Image avatar;
	public Sprite[] allWarriorSprites;
    public Sprite[] allCasterSprites;
    public Sprite[] allRangerSprites;
    public bool humanSelected = true; //this is set to true since human is pre-selected on launch
    public bool elfSelected = false;
    public bool orcSelected = false;
    public bool undeadSelected = false;

    // Use this for initialization
    void Start ()
    {
		//Grabs race button
        avatar = avatar.GetComponent<Image>();

        //Adds event listener for race button
		raceButton.onClick.AddListener(ChangeRaceImage);
    }
	
    //Human race change button event
	void ChangeRaceImage()
    {
        //WARRIOR CLASS/RACE CASES -----------------------------------------------------------------------------------------------------------------
        //all race buttons will need this format in order for ChangeHair to work properly
        //changes to default human when warrior is selected
        if (raceButton.CompareTag("HumanRace") && 
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            avatar.sprite = allWarriorSprites[0];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = true; 
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = false;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = false;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = false;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //changes to default elf when warrior is selected
        if (raceButton.CompareTag("ElfRace") && 
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            avatar.sprite = allWarriorSprites[1];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = false;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = true;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = false;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = false;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //changes to default orc when warrior is selected
        if (raceButton.CompareTag("OrcRace") &&
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            avatar.sprite = allWarriorSprites[2];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = false;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = false;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = true;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = false;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //changes to default undead when warrior is selected
        if (raceButton.CompareTag("UndeadRace") &&
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            avatar.sprite = allWarriorSprites[3];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = false;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = false;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = false;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = true;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //CASTER CLASS/RACE CASES -----------------------------------------------------------------------------------------------------------------
        //changes to default human when caster is selected
        if (raceButton.CompareTag("HumanRace") &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            avatar.sprite = allCasterSprites[0];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = true;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = false;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = false;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = false;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //changes to default elf when caster is selected
        if (raceButton.CompareTag("ElfRace") &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            avatar.sprite = allCasterSprites[1];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = false;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = true;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = false;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = false;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //changes to default orc when caster is selected
        if (raceButton.CompareTag("OrcRace") &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            avatar.sprite = allCasterSprites[2];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = false;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = false;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = true;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = false;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //changes to default undead when caster is selected
        if (raceButton.CompareTag("UndeadRace") &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            avatar.sprite = allCasterSprites[3];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = false;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = false;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = false;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = true;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //RANGER CLASS/RACE CASES -----------------------------------------------------------------------------------------------------------------
        //changes to default human when caster is selected
        if (raceButton.CompareTag("HumanRace") &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            avatar.sprite = allRangerSprites[0];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = true;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = false;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = false;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = false;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //changes to default elf when caster is selected
        if (raceButton.CompareTag("ElfRace") &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            avatar.sprite = allRangerSprites[1];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = false;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = true;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = false;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = false;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //changes to default orc when caster is selected
        if (raceButton.CompareTag("OrcRace") &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            avatar.sprite = allRangerSprites[2];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = false;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = false;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = true;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = false;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //changes to default undead when caster is selected
        if (raceButton.CompareTag("UndeadRace") &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            avatar.sprite = allRangerSprites[3];
            GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected = false;
            GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected = false;
            GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected = false;
            GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected = true;
            //GameObject.Find("StyleChangeRight1").GetComponent<ChangeHair>().hairIndex = 1; this will reset the index for the left hair change button
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }
    }
}
