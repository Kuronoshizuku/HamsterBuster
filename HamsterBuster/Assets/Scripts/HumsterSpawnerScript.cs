using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//書いた人 みくみです ハムスターを動的生成するスクリプトらしい

public class HumsterSpawnerScript : MonoBehaviour
{
	private CharacterController enemyController;
	private Animator animator;

	[SerializeField]
	public GameObject walking_angry_Humster;
	[SerializeField] 
	public int count = 0;
	[SerializeField] 
	public int max = 10;    //上限

	private Vector3 destination; //　目的地
	public Transform targetobject;
	

	[SerializeField]
	public float walkSpeed = 1.0f; //　歩くスピード
	private Vector3 velocity; //　速度
	private Vector3 direction; //　移動方向
	private bool arrived;//　到着フラグ
	private Vector3 startPosition; //　スタート位置

	// Start is called before the first frame update
	void Start()
    {
		enemyController = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();

		InvokeRepeating("Generate", 1, 1);

		/*
		var randDestination = Random.insideUnitCircle * 5;  //半径5ｍ以内にランダムに目的地をつくる
		destination = startPosition + new Vector3(randDestination.x, 0, randDestination.y);
		*/

		velocity = Vector3.zero;
		arrived = false;
		startPosition = new Vector3(0, 0, 18);
	}

	void Generate()
    {
		float x = Random.Range(0f, 9f);
		float y = 0;
		float z = Random.Range(0f, 9f);
		Vector3 position = new Vector3(x, y, z);
		Instantiate(walking_angry_Humster, new Vector3.Zero);
	}

	// Update is called once per frame
	void Update()
	{
		if (!arrived)
		{
			if (enemyController.isGrounded)
			{
				velocity = Vector3.zero;
				animator.SetFloat("Speed", 2.0f);
				direction = (destination - transform.position).normalized;//目的地方向の計算
				transform.LookAt(new Vector3(destination.x, transform.position.y, destination.z));//キャラを目的地の方向に向かせる
				velocity = direction * walkSpeed;
				Debug.Log(destination);
			}
			velocity.y += Physics.gravity.y * Time.deltaTime;
			enemyController.Move(velocity * Time.deltaTime);

			//　目的地に到着したかどうかの判定
			if (Vector3.Distance(transform.position, destination) < 0.5f)
			{
				arrived = true;
				animator.SetFloat("Speed", 0.0f);
				transform.LookAt(targetobject);
			}
		}
	}
}
