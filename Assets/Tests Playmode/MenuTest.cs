using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

namespace Tests
{
	public class MenuTest
	{
		private Button start_button;

		// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
		// `yield return null;` to skip a frame.
		[UnityTest]
		public IEnumerator MenuTestWithEnumeratorPasses()
		{

			SceneManager.LoadScene("Menu");

			yield return new WaitForSeconds(4);

			start_button = GameObject.Find("btn_start").GetComponent<Button>();
			start_button.onClick.Invoke();

			yield return new WaitForSeconds(4);

			String new_scene = SceneManager.GetActiveScene().name;

			yield return new WaitForSeconds(4);

			Debug.Log(SceneManager.GetActiveScene().name);

			Assert.True(new_scene == "Forest");
		}
	}
}
