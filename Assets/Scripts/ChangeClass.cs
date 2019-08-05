using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeClass : MonoBehaviour
{
    //Global variables
    public Button classButton;
    public Image avatar;
    //dont need an array of sprites because astehtic options are not a concern with class
    //selecting a new class will revert back to basic sprite with the selected class
    public Sprite humanWarriorSprite;
    public Sprite elfWarriorSprite;
    public Sprite orcWarriorSprite;
    public Sprite undeadWarriorSprite;
    public Sprite humanCasterSprite;
    public Sprite elfCasterSprite;
    public Sprite orcCasterSprite;
    public Sprite undeadCasterSprite;
    public Sprite humanRangerSprite;
    public Sprite elfRangerSprite;
    public Sprite orcRangerSprite;
    public Sprite undeadRangerSprite;
    public bool warriorSelected = true;
    public bool casterSelected = false;
    public bool rangerSelected = false;

    // Use this for initialization
    void Start()
    {
        //Grabs race button
        avatar = avatar.GetComponent<Image>();

        //Adds event listener for race button
        classButton.onClick.AddListener(ChangeClassImage);
    }

    void ChangeClassImage()
    {
        //WARRIOR CLASS CASES---------------------------------------------------------------------------------------------------------------------------------------------
        //Changes avatar to human warrior sprite
        if (GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected == true &&
                classButton.CompareTag("WarriorClassButton"))
        {
            avatar.sprite = humanWarriorSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = true;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = false;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = false;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //Changes avatar to elf warrior sprite
        if (GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected == true &&
                classButton.CompareTag("WarriorClassButton"))
        {
            avatar.sprite = elfWarriorSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = true;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = false;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = false;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //Changes avatar to orc warrior sprite
        if (GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected == true &&
                classButton.CompareTag("WarriorClassButton"))
        {
            avatar.sprite = orcWarriorSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = true;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = false;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = false;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //Changes avatar to undead warrior sprite
        if (GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected == true &&
                classButton.CompareTag("WarriorClassButton"))
        {
            avatar.sprite = undeadWarriorSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = true;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = false;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = false;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //CASTER CLASS CASES---------------------------------------------------------------------------------------------------------------------------------------------
        //Changes avatar to human caster sprite
        if (GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected == true &&
                classButton.CompareTag("CasterClassButton"))
        {
            avatar.sprite = humanCasterSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = false;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = true;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = false;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //Changes avatar to elf caster sprite
        if (GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected == true &&
                classButton.CompareTag("CasterClassButton"))
        {
            avatar.sprite = elfCasterSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = false;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = true;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = false;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //Changes avatar to orc caster sprite
        if (GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected == true &&
                classButton.CompareTag("CasterClassButton"))
        {
            avatar.sprite = orcCasterSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = false;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = true;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = false;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //Changes avatar to undead caster sprite
        if (GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected == true &&
                classButton.CompareTag("CasterClassButton"))
        {
            avatar.sprite = undeadCasterSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = false;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = true;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = false;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //RANGER CLASS CASES---------------------------------------------------------------------------------------------------------------------------------------------
        //Changes avatar to human caster sprite
        if (GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected == true &&
                classButton.CompareTag("RangerClassButton"))
        {
            avatar.sprite = humanRangerSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = false;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = false;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = true;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //Changes avatar to elf caster sprite
        if (GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected == true &&
                classButton.CompareTag("RangerClassButton"))
        {
            avatar.sprite = elfRangerSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = false;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = false;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = true;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //Changes avatar to orc caster sprite
        if (GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected == true &&
                classButton.CompareTag("RangerClassButton"))
        {
            avatar.sprite = orcRangerSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = false;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = false;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = true;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }

        //Changes avatar to undead caster sprite
        if (GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected == true &&
                classButton.CompareTag("RangerClassButton"))
        {
            avatar.sprite = undeadRangerSprite;
            GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected = false;
            GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected = false;
            GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected = true;
            GameObject.Find("HairChangeRight").GetComponent<ChangeHair>().hairIndex = 0;
            GameObject.Find("HairChangeLeft").GetComponent<ChangeHair>().hairIndex = 0;
        }
    }
}
