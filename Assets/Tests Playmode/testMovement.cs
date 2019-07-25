using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class Movementy
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


            Quaternion player_original_rotation = player.transform.rotation;

            //Move player using joystick handle
            handle.transform.position = new Vector3(100, handle.transform.position.y, handle.transform.position.z);

            Quaternion player_new_rotation = player.transform.rotation;

            yield return null;


            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return new WaitForSeconds(1);

            Assert.False(player_original_rotation == player_new_rotation);
        }
    }
}