using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomization : MonoBehaviour {

 

   
    public SpriteRenderer maleTorsoRenderer;
    public SpriteRenderer femaleTorsoRenderer;

    public SpriteRenderer maleLegsRenderer;
    public SpriteRenderer femaleLegsRenderer;

    public SpriteRenderer maleFeetRenderer;
    public SpriteRenderer femaleFeetRenderer;

    
    public Sprite maleTorso, femaleTorso;
    public Sprite maleLegs, femaleLegs;
    public Sprite maleFeet, femaleFeet;

    
    public Color[] torsoColors;
    public Color[] legsColors;
    public Color[] feetColors;

   
    private bool isMale = true;  
    private int torsoColorIndex = 0;
    private int legsColorIndex = 0;
    private int feetColorIndex = 0;

   
    public Button startCustomizationButton;
    public Button genderSwapButton;
    public Button torsoColorButton;
    public Button legsColorButton;
    public Button feetColorButton;

    
   
    void Start()
    {
        
      

       
        startCustomizationButton.onClick.AddListener(StartCustomization);
        genderSwapButton.onClick.AddListener(SwapGender);
        torsoColorButton.onClick.AddListener(ChangeTorsoColor);
        legsColorButton.onClick.AddListener(ChangeLegsColor);
        feetColorButton.onClick.AddListener(ChangeFeetColor);

       
        UpdateCharacterAppearance();
    }

    void StartCustomization()
    {
        
       

       
        startCustomizationButton.gameObject.SetActive(false);
    }

    void SwapGender()
    {
       
        isMale = !isMale;
        UpdateCharacterAppearance();
    }

    void ChangeTorsoColor()
    {
        
        torsoColorIndex = (torsoColorIndex + 1) % torsoColors.Length;
        UpdateCharacterAppearance();
    }

    void ChangeLegsColor()
    {
       
        legsColorIndex = (legsColorIndex + 1) % legsColors.Length;
        UpdateCharacterAppearance();
    }

    void ChangeFeetColor()
    {
       
        feetColorIndex = (feetColorIndex + 1) % feetColors.Length;
        UpdateCharacterAppearance();
    }

    void UpdateCharacterAppearance()
    {
       
        if (isMale)
        {
            maleTorsoRenderer.enabled = true;
            femaleTorsoRenderer.enabled = false;

            maleLegsRenderer.enabled = true;
            femaleLegsRenderer.enabled = false;

            maleFeetRenderer.enabled = true;
            femaleFeetRenderer.enabled = false;

           
            maleTorsoRenderer.color = torsoColors[torsoColorIndex];
            maleLegsRenderer.color = legsColors[legsColorIndex];
            maleFeetRenderer.color = feetColors[feetColorIndex];
        }
        else
        {
            maleTorsoRenderer.enabled = false;
            femaleTorsoRenderer.enabled = true;

            maleLegsRenderer.enabled = false;
            femaleLegsRenderer.enabled = true;

            maleFeetRenderer.enabled = false;
            femaleFeetRenderer.enabled = true;

            
            femaleTorsoRenderer.color = torsoColors[torsoColorIndex];
            femaleLegsRenderer.color = legsColors[legsColorIndex];
            femaleFeetRenderer.color = feetColors[feetColorIndex];
        }
    }
}
