using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class CharacterMove : MonoBehaviour {
	public float speed = 0.0f;
	public GameObject Target;
	public GameObject blood;

	private string jsonString;
	private JsonData playerData;

	JsonData playerJson;
	public Character player;

	public GameObject enemyslider;
	public GameObject enemyslider2;
	public GameObject enemyslider3;

	public Slider hpslider;
	public Slider repslider;
	public Text hptext;
	public Text reptext;
	public Text statustext;
	public Image youdiedImage;
	public Text youdiedText;

	public bool isClicked = false;
	public Button attackbutton;
	public Button nicknamebutton;
	public InputField nicknameinputfield;

	public int level, hp, hpmax, rep, repmax, radius, attack;
	public string name;
	protected Animator animator;
	protected Animator animator2;
	protected Animator animator3;
	public bool isDamaged = false;

	CharacterAttribute myAttribute;
	CharacterAttribute myAttribute2;
	CharacterAttribute myAttribute3;
	playerMgr pm;
	public bool slimeDamaged = false;
	public bool lavaDamaged = false;
	public bool snailDamaged = false;

	public GameObject other;
	public GameObject other2;
	public GameObject otherPlayer;

	public GameObject applePrefab;
	public GameObject cherryblossomPrefab;
	public GameObject sulfurPrefab;

	public enum State {
		MOVE,
		ATTACK,
		DAMAGED,
		DIED
	};
	private State currentState_ = State.MOVE;

	public void SetState(State newState) {
		if (newState == currentState_) {
			return;
		}
		currentState_ = newState;
		switch(newState) {
		case State.MOVE:
			{
				MoveState ();
			}break;
		case State.ATTACK:
			{
				AttackState ();
			}break;
		case State.DAMAGED:
			{
				DamagedState ();
			}
			break;
		case State.DIED:
			{
				DiedState ();
			}
			break;
		}
	}

	void Awake() {
		sceneLoad ();
		level = int.Parse (playerData ["level"].ToString ());
		hp = int.Parse (playerData ["health"].ToString ());
		rep = int.Parse (playerData ["reputation"].ToString ());
		hpmax = int.Parse (playerData ["stats"] [0].ToString ());
		repmax = int.Parse (playerData ["stats"] [1].ToString ());
		radius = int.Parse (playerData ["stats"] [2].ToString ());
		attack = int.Parse (playerData ["stats"] [3].ToString ());
		name = playerData ["name"].ToString ();
		print ();
		myAttribute = gameObject.GetComponent<CharacterAttribute> ();
		myAttribute2 = other.GetComponent<CharacterAttribute> ();
		myAttribute3 = other2.GetComponent<CharacterAttribute> ();
		animator = this.GetComponent <Animator> ();
		animator2 = other.GetComponent <Animator> ();
		animator3 = other2.GetComponent<Animator> ();
		pm = otherPlayer.GetComponent<playerMgr> ();
		youdiedImage.enabled = false;
		youdiedText.text = "";
	}

	// Update is called once per frame
	void Update () {
		sceneLoad ();
		print ();
		Button btn = nicknamebutton.GetComponent<Button>();
		btn.onClick.AddListener(changeNickname);
		Button btn2 = attackbutton.GetComponent<Button>();

		Invoke ("sceneSave", 0.1f);

		if (Target != null) {
			if (this.gameObject != null) {
				Vector3 dir = Target.transform.position - this.transform.position;
				dir.Normalize ();
				float distance = Vector3.Distance (Target.transform.position, this.transform.position);

				if (distance <= 5.0f && distance > 3.0f) {
					speed = 0.5f;
					this.transform.position += (dir * speed * Time.deltaTime);
					isDamaged = false;
					slimeDamaged = false;
					animator.SetBool ("slimeDamaged", slimeDamaged);
				} else if (distance <= 3.0f) {
					SetState (State.ATTACK);
					if (isClicked == true) {
						slimeDamaged = true;
						animator.SetBool ("slimeDamaged", slimeDamaged);
						AttackEnemy ();
						slimeDamaged = false;
						isClicked = false;
					}
				} else {
					speed = 0.0f;
					slimeDamaged = false;
					animator.SetBool ("slimeDamaged", slimeDamaged);
				}
			}//slime

			if (other != null) {
				Vector3 dir2 = Target.transform.position - other.transform.position;
				dir2.Normalize ();
				float distance2 = Vector3.Distance (Target.transform.position, other.transform.position);

				if (distance2 <= 5.0f && distance2 > 3.0f) {
					speed = 0.5f;
					other.transform.position += (dir2 * speed * Time.deltaTime);
					lavaDamaged = false;
					animator2.SetBool ("lavaDamaged", lavaDamaged);
				} else if (distance2 <= 3.0f) {
					SetState (State.ATTACK);
					if (isClicked == true) {
						AttackEnemy ();
						isClicked = false;
						lavaDamaged = true;
						animator2.SetBool ("lavaDamaged", lavaDamaged);
					}
				} else {
					speed = 0.0f;
					lavaDamaged = false;
					animator2.SetBool ("lavaDamaged", lavaDamaged);
				}
			}//lava

			if (other2 != null) {
				Vector3 dir3 = Target.transform.position - other2.transform.position;
				dir3.Normalize ();
				float distance3 = Vector3.Distance (Target.transform.position, other2.transform.position);

				if (distance3 <= 5.0f && distance3 > 3.0f) {
					speed = 0.5f;
					other2.transform.position += (dir3 * speed * Time.deltaTime);
					snailDamaged = false;
					animator3.SetBool ("snailDamaged", snailDamaged);
				} else if (distance3 <= 3.0f) {
					SetState (State.ATTACK);
					if (isClicked == true) {
						AttackEnemy ();
						isClicked = false;
						snailDamaged = true;
						animator3.SetBool ("snailDamaged", snailDamaged);
					}
				} else {
					speed = 0.0f;
					snailDamaged = false;
					animator3.SetBool ("snailDamaged", snailDamaged);
				}
			}//slime
		}
	}

	public void btn2Clicked() {
		isClicked = true;
	}

	public void playSound(){
		GameObject.Find ("audioAttack").GetComponent<AudioSource> ().Play();
	}

	public void AttackEnemy() {
		if (pm.who == "slime") {
			myAttribute.HP -= attack;
			if (myAttribute.HP <= 0) {
				myAttribute.HP = 0;
				SetState (State.DIED);
			}
		} else if (pm.who == "lava") {
			myAttribute2.HP -= attack;
			if (myAttribute2.HP <= 0) {
				myAttribute2.HP = 0;
				SetState (State.DIED);
			}
		} else if (pm.who == "snail") {
			myAttribute3.HP -= attack;
			if (myAttribute3.HP <= 0) {
				myAttribute3.HP = 0;
				SetState (State.DIED);
			}
		}
	}

	void AttackState () {
		Debug.Log (pm.who);
		isDamaged = true;
		if (pm.who == "slime") {
			hp -= myAttribute.AttackPower;
			Instantiate (blood, this.transform.position, this.transform.rotation);
		}
		else if (pm.who == "lava") {
			hp -= myAttribute2.AttackPower;
			Instantiate (blood, other.transform.position, other.transform.rotation);
		}
		else if (pm.who == "snail") {
			hp -= myAttribute3.AttackPower;
			Instantiate (blood, other2.transform.position, other2.transform.rotation);
		}
		CharacterMove targetStateManager = Target.GetComponent<CharacterMove> ();

		if (hp <= 0) {
			hp = 0;
			sceneSave ();
			GameObject.Find ("audioBgm").GetComponent<AudioSource> ().Stop ();
			GameObject.Find ("audioDied").GetComponent<AudioSource> ().Play();
			youdiedImage.enabled = true;
			youdiedText.text = "YOU DIED";
			StartCoroutine ("playerDied", 1.0f);
		}
		StartCoroutine ("TransStateToMove", myAttribute.AttackTime);
		StartCoroutine ("TransStateToMove", myAttribute2.AttackTime);
		StartCoroutine ("TransStateToMove", myAttribute3.AttackTime);
	}
		
	IEnumerator playerDied(float regret) {
		yield return new WaitForSeconds (regret);
		SceneManager.LoadScene ("home");
	}

	public void recovery() {
		hp = hpmax;
		sceneSave ();
		print ();
	}

	public void levelsystem() {
		if (rep < 50) {
			level = 1;
			hpmax = 100;
			attack = 10;
		} else if (rep >= 50 && rep < 100) {
			level = 2;
			hpmax = 150;
			attack = 15;
		} else if (rep >= 100 && rep < 150) {
			level = 3;
			hpmax = 200;
			attack = 20;
		} else if (rep >= 150 && rep < 200) {
			level = 4;
			hpmax = 250;
			attack = 25;
		} else if (rep >= 200 && rep < 250) {
			level = 5;
			hpmax = 300;
			attack = 30;
		} else {
			level = 5;
			hpmax = 300;
			attack = 30;
		}
	}

	void MoveState () {
	}

	void DamagedState() {
	}

	void DiedState() {
		if (pm.who == "slime") {
			Destroy (gameObject);
			Destroy (enemyslider);
			Instantiate (sulfurPrefab, this.transform.position, Quaternion.identity);
			pm.who = "";
		}
		else if (pm.who == "lava") {
			Destroy (other);
			Destroy (enemyslider2);
			Instantiate (cherryblossomPrefab, other.transform.position, Quaternion.identity);
			pm.who = "";
		}
		else if (pm.who == "snail") {
			Destroy (other2);
			Destroy (enemyslider3);
			Instantiate (applePrefab, other2.transform.position, Quaternion.identity);
			pm.who = "";
		}
		/*
		int rand = Random.Range (0, 2);
		switch (rand) {
		case 0:
			{
				Instantiate (sulfurPrefab, transform.position, Quaternion.identity);
			}
			break;
		case 1:
			{
				Instantiate (cherryblossomPrefab, transform.position, Quaternion.identity);
			}
			break;
		case 2:
			{
				Instantiate (applePrefab, transform.position, Quaternion.identity);
			}
			break;
		}
		*/
	}


	public void sceneLoad() {
		string filepath = "";

		#if UNITY_ANDROID
		filepath = Application.persistentDataPath + "/Player.json";
		if(File.Exists(filepath)) {
			jsonString = File.ReadAllText(filepath);
			playerData = JsonMapper.ToObject (jsonString);
		} else {
			player = new Character(1, "john", 100, 10, new int[] {100,400,1,10});
			playerJson = JsonMapper.ToJson(player);
			File.WriteAllText (Application.persistentDataPath + "/Player.json", playerJson.ToString ());
		}
		#endif

		#if UNITY_EDITOR
		filepath = Application.dataPath + "/StreamingAssets/Player.json";
		if(File.Exists(filepath)) {
			jsonString = File.ReadAllText(filepath);
			playerData = JsonMapper.ToObject (jsonString);
		} else {
			player = new Character(1, "john", 100, 10, new int[] {100,400,1,10});
			playerJson = JsonMapper.ToJson(player);
			File.WriteAllText (Application.dataPath + "/StreamingAssets/Player.json", playerJson.ToString ());
			sceneLoad();
		}
		#endif
	}

	public void sceneSave() {
		player = new Character (level, name, hp, rep, new int[] { hpmax, repmax, radius, attack });
		playerJson = JsonMapper.ToJson (player);
		#if UNITY_ANDROID
		File.WriteAllText (Application.persistentDataPath + "/Player.json", playerJson.ToString ());
		#endif

		#if UNITY_EDITOR
		File.WriteAllText (Application.dataPath + "/StreamingAssets/Player.json", playerJson.ToString ());
		#endif
	}

	void print() {
		hpslider.value = (float)hp / (float)hpmax;
		repslider.value = (float)rep / (float)repmax;
		hptext.text = (float)hp + "/" + (float)hpmax;
		reptext.text = (float)rep + "/" + (float)repmax;
		statustext.text = "Lv." + int.Parse (playerData ["level"].ToString ()) + " " + playerData["name"].ToString() + "\nATK " + int.Parse(playerData["stats"][3].ToString());
	}

	void changeNickname() {
		name = nicknameinputfield.text;
		sceneSave ();
		print ();
	}

	IEnumerator TransStateToMove(float waitTime) {
		yield return new WaitForSeconds (waitTime);
		SetState (State.MOVE);
	}

	public class Character {
		public int level;
		public string name;
		public int health;
		public int reputation;
		public int[] stats;//{healthMax,repMax,radius,atk}

		public Character(int level, string name, int health, int reputation, int[] stats) {
			this.level = level;
			this.name = name;
			this.health = health;
			this.reputation = reputation;
			this.stats = stats;
		}
	}
}
