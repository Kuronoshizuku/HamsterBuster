using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//書いた人 みくみ

public class shiikuinnController : MonoBehaviour
{
	Animator nageanim;
	//ここわからない↓
	bool nageruflg = false;

	private const string space = "nageru";

	// Use this for initialization
	void Start()
	{
		nageanim = this.gameObject.GetComponent<Animator>();
		/* このスクリプトが張り付けられているオブジェクトのコンポーネントから
		animationコンポーネントを取得 */

	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Space)) //spaceボタンを推すとnageanimを再生
		{
			nageruflg = true;
			//Debug.Log(nageruflg);
			nagemotion();
		}
		else
		{
			// nageruからidleに遷移する
			nageanim.SetBool("nageru", false);
			nageruflg = false;
		}
	}

	public void nagemotion()
	{
		if (nageruflg == true)
		{
			// idleからnageruに遷移する
			nageanim.SetBool("nageru", true);
		}
	}
}

