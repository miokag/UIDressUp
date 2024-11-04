using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesChangerManager : MonoBehaviour
{
    public Renderer clothesObjectRenderer;
    public Texture[] clothesTextures;
    private int clothesIndex;

    //Reference for buttons
    public Button clothesLeftButton;
    public Button clothesRightButton;


    // Start is called before the first frame update
    void Start()
    {
        //set initial texture
        if(clothesObjectRenderer != null && clothesTextures.Length > 0)
        {
            clothesObjectRenderer.material.mainTexture = clothesTextures[clothesIndex];
        }

        //add onclick list
        clothesLeftButton.onClick.AddListener(ChangeClothesTextureLeft);
        clothesRightButton.onClick.AddListener(ChangeClothesTextureRight);
    }

    void ChangeClothesTextureLeft()
    {
        clothesIndex--;
        if(clothesIndex < 0 )
        {
            clothesIndex =  clothesTextures.Length - 1;
        }
        UpdateClothesTexture();
    }

    void ChangeClothesTextureRight()
    {
        clothesIndex++;
        if (clothesIndex >= clothesTextures.Length)
        {
            clothesIndex = 0;
        }
        UpdateClothesTexture();
    }

    public void UpdateClothesTexture()
    {
        clothesObjectRenderer.material.mainTexture = clothesTextures[clothesIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
