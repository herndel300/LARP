using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHair : MonoBehaviour
{
    //Global variables
    public Button hairChangeForward;
    public Button hairChangeBackward;
    public Image avatar;
    public Sprite[] humanWarriorSprites;
    public Sprite[] elfWarriorSprites;
    public Sprite[] orcWarriorSprites;
    public Sprite[] undeadWarriorSprites;
    public Sprite[] humanCasterSprites;
    public Sprite[] elfCasterSprites;
    public Sprite[] orcCasterSprites;
    public Sprite[] undeadCasterSprites;
    public Sprite[] humanRangerSprites;
    public Sprite[] elfRangerSprites;
    public Sprite[] orcRangerSprites;
    public Sprite[] undeadRangerSprites;
    public int hairIndex = 0;

    // Use this for initialization
    void Start()
    {
        //Grabs race button
        avatar = avatar.GetComponent<Image>();

        //Adds event listener for race button
        hairChangeForward.onClick.AddListener(ChangeHairImageForward);
        hairChangeBackward.onClick.AddListener(ChangeHairImageBackward);
    }

    void ChangeHairImageForward()
    {
        //WARRIOR CASES -------------------------------------------------------------------------------------------------------------------
        //Changes array of sprites to human warrior if elf race and warrior class are selected
        if (GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected == true && 
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }
 
            avatar.sprite = humanWarriorSprites[hairIndex];
        }

        //Changes array of sprites to elf warrior if elf race and warrior class are selected
        if (GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected == true &&
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = elfWarriorSprites[hairIndex];
        }

        //Changes array of sprites to orc warrior if orc race and warrior class are selected
        if (GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected == true &&
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = orcWarriorSprites[hairIndex];
        }

        //Changes array of sprites to undead warrior if undead race and warrior class are selected
        if (GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected == true &&
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = undeadWarriorSprites[hairIndex];
        }

        //CASTER CASES -------------------------------------------------------------------------------------------------------------------
        //Changes array of sprites to human warrior if elf race and warrior class are selected
        if (GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected == true &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = humanCasterSprites[hairIndex];

        }

        //Changes array of sprites to elf warrior if elf race and warrior class are selected
        if (GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected == true &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = elfCasterSprites[hairIndex];
        }

        //Changes array of sprites to orc warrior if orc race and warrior class are selected
        if (GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected == true &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = orcCasterSprites[hairIndex];
        }

        //Changes array of sprites to undead warrior if undead race and warrior class are selected
        if (GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected == true &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = undeadCasterSprites[hairIndex];
        }

        //RANGER CASES -------------------------------------------------------------------------------------------------------------------
        //Changes array of sprites to human warrior if elf race and warrior class are selected
        if (GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected == true &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = humanRangerSprites[hairIndex];
        }

        //Changes array of sprites to elf warrior if elf race and warrior class are selected
        if (GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected == true &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = elfRangerSprites[hairIndex];
        }

        //Changes array of sprites to orc warrior if orc race and warrior class are selected
        if (GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected == true &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = orcRangerSprites[hairIndex];
        }

        //Changes array of sprites to undead warrior if undead race and warrior class are selected
        if (GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected == true &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            hairIndex++;

            if (hairIndex > 6)
            {
                hairIndex = 0;
            }

            avatar.sprite = undeadRangerSprites[hairIndex];
        }
    }

    void ChangeHairImageBackward()
    {
        //WARRIOR CASES -------------------------------------------------------------------------------------------------------------------
        //Changes array of sprites to human warrior if elf race and warrior class are selected
        if (GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected == true &&
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = humanWarriorSprites[hairIndex];

        }

        //Changes array of sprites to elf warrior if elf race and warrior class are selected
        if (GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected == true &&
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = elfWarriorSprites[hairIndex];
        }

        //Changes array of sprites to orc warrior if orc race and warrior class are selected
        if (GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected == true &&
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = orcWarriorSprites[hairIndex];
        }

        //Changes array of sprites to undead warrior if undead race and warrior class are selected
        if (GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected == true &&
                GameObject.Find("WarriorClassButton").GetComponent<ChangeClass>().warriorSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = undeadWarriorSprites[hairIndex];
        }

        //CASTER CASES -------------------------------------------------------------------------------------------------------------------
        //Changes array of sprites to human warrior if elf race and warrior class are selected
        if (GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected == true &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = humanCasterSprites[hairIndex];

        }

        //Changes array of sprites to elf warrior if elf race and warrior class are selected
        if (GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected == true &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = elfCasterSprites[hairIndex];
        }

        //Changes array of sprites to orc warrior if orc race and warrior class are selected
        if (GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected == true &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = orcCasterSprites[hairIndex];
        }

        //Changes array of sprites to undead warrior if undead race and warrior class are selected
        if (GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected == true &&
                GameObject.Find("CasterClassButton").GetComponent<ChangeClass>().casterSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = undeadCasterSprites[hairIndex];
        }

        //RANGER CASES -------------------------------------------------------------------------------------------------------------------
        //Changes array of sprites to human warrior if elf race and warrior class are selected
        if (GameObject.Find("HumanButton").GetComponent<ChangeRace>().humanSelected == true &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = humanRangerSprites[hairIndex];
        }

        //Changes array of sprites to elf warrior if elf race and warrior class are selected
        if (GameObject.Find("ElfButton").GetComponent<ChangeRace>().elfSelected == true &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = elfRangerSprites[hairIndex];
        }

        //Changes array of sprites to orc warrior if orc race and warrior class are selected
        if (GameObject.Find("OrcButton").GetComponent<ChangeRace>().orcSelected == true &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = orcRangerSprites[hairIndex];
        }

        //Changes array of sprites to undead warrior if undead race and warrior class are selected
        if (GameObject.Find("UndeadButton").GetComponent<ChangeRace>().undeadSelected == true &&
                GameObject.Find("RangerClassButton").GetComponent<ChangeClass>().rangerSelected == true)
        {
            hairIndex--;

            if (hairIndex <= -1)
            {
                hairIndex = 6;
            }

            avatar.sprite = undeadRangerSprites[hairIndex];
        }
    }

}
