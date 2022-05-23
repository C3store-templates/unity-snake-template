using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTrigger : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			Coin.coin++;
		
		}
		else if(collision.gameObject.CompareTag("Coin"))
		{
			Destroy(collision.gameObject);
			Coin.coin = 0;
		}
	}
}
