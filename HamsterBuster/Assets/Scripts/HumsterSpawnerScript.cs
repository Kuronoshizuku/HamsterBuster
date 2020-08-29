using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//書いた人 みくみです ハムスターを動的生成するスクリプトらしい

public class HumsterSpawnerScript : MonoBehaviour
{
	public GameObject humsterparents;
	public CharacterController enemyController;
	public Animator animator;
	public GameObject walking_angry_HumsterPrefab;
	public int max;    //上限

	private Vector3 destination; //　目的地
	public Transform targetobject;
	public GameObject hum;
	int counthum;
	public static int spawncount = 5;//スポーンする上限


	[SerializeField]
	public float walkSpeed = 1.0f; //　歩くスピード
	private Vector3 velocity; //　速度
	private Vector3 direction; //　移動方向
	private bool arrived;//　到着フラグ
	private Vector3 startPosition; //　スタート位置

    private void Start()
    {
		int counthum = GameObject.FindGameObjectsWithTag("humster").Length;
		if (counthum < 10)
		{
			StartCoroutine(timer());
		}
	}

    IEnumerator timer()
    {
		yield return new WaitForSeconds(3);

		Generate();

	}

    // Update is called once per frame
    /*	void Update()
        {
            //InvokeRepeating("Generate", 1, 1); // 1秒ごとに繰り返す
        }
    */

    private void Generate()
	{
		startPosition = new Vector3(0, 0, 18);
		//public staticをつけた変数を取得
		//int i = UInumScript.counthum;

		for (int i = counthum; i < 1; i++)
			{
				//humをインスタンス化する(生成する)
				GameObject hum = Instantiate(
				walking_angry_HumsterPrefab,
				startPosition,
				Quaternion.identity
				);

				//生成したオブジェクトの親設定
				hum.transform.parent = humsterparents.transform;

			}
		spawncount -= 1;

		Start();

	}

}
