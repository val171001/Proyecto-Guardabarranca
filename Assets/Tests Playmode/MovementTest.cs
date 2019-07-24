using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class movement_test
    {

        private GameObject controls;
        private GameObject joystick;
        private GameObject handle;
        private GameObject player;

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator movement_testWithEnumeratorPasses()
        {

            SceneManager.LoadScene("Forest");

            yield return new WaitForSeconds(4);

            // This gets the GameObject named handel
            controls = GameObject.Find("Controls");
            joystick = controls.transform.GetChild(0).gameObject;
            handle = joystick.transform.GetChild(0).gameObject;

            // Gests player
            player = GameObject.Find("Player");

            Vector3 player_original_postion = player.transform.position;

            handle.transform.position = new Vector3(handle.transform.position.x, 99, handle.transform.position.z);

            yield return null;

            Vector3 player_new_postion = player.transform.position;

            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return new WaitForSeconds(1);

            Assert.True(player_original_postion != player_new_postion);
        }
    }
}
