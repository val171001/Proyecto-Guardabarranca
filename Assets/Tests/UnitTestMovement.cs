using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class UnitTestMovement
    {

        private GameObject controls;
        private GameObject joystick;
        private GameObject handle;

        // A Test behaves as an ordinary method
        [Test]
        public void UnitTestMovementSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator UnitTestMovementWithEnumeratorPasses()
        {
            // This returns the GameObject named Hand.
            controls = GameObject.Find("Controls");
            joystick = controls.transform.GetChild(0).gameObject;
            handle = joystick.transform.GetChild(0).gameObject;
            
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;

            Assert.False(handle.GetComponent("Player Movement").name == "Hola");
        }
    }
}
