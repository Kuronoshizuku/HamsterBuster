using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//書いた人 みくみ すみません

public class McontrollhumScript : MonoBehaviour
{

	public CharacterController enemyController;
	public Animator animator;
	public GameObject walking_angry_HumsterPrefab;
	public int count = 0;
	public int max = 10;    //上限

	private Vector3 destination; //　目的地
	public Transform targetobject;
	[SerializeField]
	public float walkSpeed = 1.0f; //　歩くスピード
	private Vector3 velocity; //　速度
	private Vector3 direction; //　移動方向
	private bool arrived;//　到着フラグ
	private Vector3 startPosition; //　スタート位置

	void Start()
	{
		enemyController = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();

		velocity = Vector3.zero;
		arrived = false;
		startPosition = new Vector3(0, 0, 18);


	}

	public void Update()
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
				//Debug.Log(destination);
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
