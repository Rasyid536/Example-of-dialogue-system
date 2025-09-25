using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Branching : MonoBehaviour
{
    public TextMeshProUGUI branchTextOptionA, branchTextOptionB;
    private bool finalBranch;
    public bool IsOptionTrue;
    public GameObject Option;
    public Dialogue dialogue;
    public bool isBranching;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isBranching = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Option.activeSelf)
        {
            IsOptionTrue = true;
        }
        else
        {
            IsOptionTrue = false;
        }
        Branchings();
        BranchDialogue();
    }

    public void Branched()
    {
        isBranching = true;
        if(dialogue.index == 26)
        {
            dialogue.lines[27] = "”But didn’t you......”";
        }

        if(dialogue.index == 91)
        {
            dialogue.lines[92] = "”You sure about this?”";
        }
        if(finalBranch == true)
        {
            SceneManager.LoadScene("BranchScene");
        }
        
        Option.SetActive(false);
        dialogue.NewLine();
    }
    public void NotBranched()
    {
        if(dialogue.index == 26)
        {
            dialogue.lines[27] = "”I was just playing around”.";
        }
        
        if(dialogue.index == 91)
        {
            dialogue.lines[92] = "”Are you insane? How could I do that?”";
        }
        Option.SetActive(false);
        isBranching = false;
    }
    void Branchings()
    {
        if(dialogue.index == 133)
        {
            if(dialogue.textComponent.text == dialogue.lines[dialogue.index])
            Option.SetActive(true);
            
            finalBranch = true;
            branchTextOptionA.text = "I thought she was fine.";
            branchTextOptionB.text = "Maybe I really should go home now.";

        }
        

        if(dialogue.index == 26)
        {
            if(dialogue.textComponent.text == dialogue.lines[dialogue.index])
            Option.SetActive(true);
            branchTextOptionA.text = "I was just playing around.";
            branchTextOptionB.text = "But didn’t you?";
        }

        if(dialogue.index == 91)
        {
            if(dialogue.textComponent.text == dialogue.lines[dialogue.index])
            Option.SetActive(true);
            branchTextOptionA.text = "Are you insane? How could I do that?";
            branchTextOptionB.text = "You sure about this?";
        }
        

    }

    void BranchDialogue()// branching di dialog
    { 
        //branch1
        if(isBranching == true && dialogue.index < 30)
        {
            dialogue.lines[27] = "”But didn’t you......”";
            dialogue.lines[28] = "……………………….....…";
            
        }
        if(dialogue.index == 29)
        {
            isBranching = false;
        }


        if(isBranching == true && dialogue.index > 30)//branch2
        {
            dialogue.lines[92] = "”You sure about this?”";
            dialogue.lines[93] = "”Yes, do it quick.”";
            dialogue.lines[94] = "I trembled, am i really gonna do this";
            dialogue.lines[95] = "Am I insane?";
            dialogue.lines[96] = "I grab the butcher knife and cut her hands off while she scream in agony.";
            
        }
        if(dialogue.index == 97)
        {
            isBranching = false;
        }     
    }
    
}
