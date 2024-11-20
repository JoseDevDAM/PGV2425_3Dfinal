using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text collectiblesNumbersText;

    private int collectiblesNumber;

    public TMP_Text totalCollectiblesNumbersText;

    private int totalCollectiblesNumbers;


    // Start is called before the first frame update
    void Start()
    {
        totalCollectiblesNumbers = transform.childCount;
        totalCollectiblesNumbersText.text = totalCollectiblesNumbers.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void AddCollectible()
    {
        collectiblesNumber++;

        collectiblesNumbersText.text = collectiblesNumber.ToString();
    } 

}
