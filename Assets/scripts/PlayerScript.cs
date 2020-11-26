using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

// ----- Low Poly FPS Pack Free Version -----
public class PlayerScript : MonoBehaviour {

	//Used to check if the target has been hit
	public bool isHit = false;
	public static float Dam = 5;
	public static float exp = 0;
	public static float level = 1;
	public static float max_player_hp;
	public static float player_hp = 100;
	public GameObject player;
	public Image blood;
	public Animator animator;

	private void Awake(){
		max_player_hp = 100;
	}
	private void Update () {

		//If the target is hit
		if (isHit == true) 
		{
			player_hp = player_hp - Dam;
			isHit = false;
			StartCoroutine(showblood());
			// animator.SetTrigger("attack");
		}
		if(player_hp <= 0){
			Destroy(player);
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			SceneManager.LoadScene("GameOver"); // 플레이어가 죽으면 게임 신으로 이동
			player_hp=100; // 플레이어 사망시 hp 및 레벨 초기화
			level=1;
		}
		
		level_up();
		

	}

	private void OnCollisionEnter(Collision collision){
		if(collision.collider.tag == "enemy"){
			isHit = true;
			collision.collider.tag = "attack_now";
		}
		if(collision.collider.tag == "enemy_leg"){
			isHit = true;
			collision.collider.tag = "attack_now1";
		}
		if(collision.collider.tag == "enemy2"){
			isHit = true;
			collision.collider.tag = "attack_now2";
		}
	}



	private void level_up(){
		if(exp >= 10){
			level++;
			exp = exp - 10;
			Debug.Log("level : " + level);
			max_player_hp = 100 + 10*(level - 1);
			player_hp = max_player_hp;
		}
	}

	IEnumerator showblood(){
		blood.color = new Color(1,0,0,UnityEngine.Random.Range(0.5f,0.6f));
		yield return new WaitForSeconds(0.3f);
		blood.color = Color.clear;
	}
	
	//Time before the target pops back up
}
// ----- Low Poly FPS Pack Free Version -----