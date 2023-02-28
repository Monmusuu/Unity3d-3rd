using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectingCoins : MonoBehaviour
{
    public int coins;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coins")

        {
            Debug.Log("Coin collected!");
            coins = coins + 1;
            Col.gameObject.SetActive(false);
            if (coins == 5)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
