using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
	public GameObject Coin;
	public GameObject Coin1;
	public GameObject Coin2;
	public GameObject Coin3;
	public GameObject Coin4;
	public GameObject Coin5;
    public GameObject Coin6;
    public GameObject Coin7;
	public GameObject EndCoin;

    void OnCollisionEnter2D(UnityEngine.Collision2D collisionInfo)
    {
    	
    	if (collisionInfo.gameObject.tag == "Coin")
    	{
    		Coin.SetActive(false);
    	}

    	if (collisionInfo.gameObject.tag == "Coin1")
    	{
    		Coin1.SetActive(false);
    	}

    	if (collisionInfo.gameObject.tag == "Coin2")
    	{
    		Coin2.SetActive(false);
    	}

    	if (collisionInfo.gameObject.tag == "Coin3")
    	{
    		Coin3.SetActive(false);
    	}

    	if (collisionInfo.gameObject.tag == "Coin4")
    	{
    		Coin4.SetActive(false);
    	}

    	if (collisionInfo.gameObject.tag == "Coin5")
    	{
    		Coin5.SetActive(false);
    	}

        if (collisionInfo.gameObject.tag == "Coin6")
        {
            Coin6.SetActive(false);
        }

        if (collisionInfo.gameObject.tag == "Coin7")
        {
            Coin7.SetActive(false);
        }

    	if (collisionInfo.gameObject.tag == "EndCoin")
    	{
    		EndCoin.SetActive(false);
    	}

        if (collisionInfo.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameOverScreen");
        }
    }
}
