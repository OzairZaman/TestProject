using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.Assertions;

namespace Tests
{
    public class SampleTests
    {
        public GameObject game;
        public Player player;

        // Sets up the Test Objects (Per Test)
        [UnitySetUp]
        public IEnumerator SetUp()
        {
            GameObject gamePrefab = Resources.Load<GameObject>("Prefabs/Game");
            game = Object.Instantiate(gamePrefab);
            player = game.GetComponentInChildren<Player>();
            yield return null;
        }

        // Destroys the Test Objects (Per Test)
        [UnityTearDown]
        public IEnumerator TearDown()
        {
            Object.Destroy(game);
            yield return null;
        }

        [UnityTest]
        public IEnumerator PlayerMovement()
        {
            // Get Original Position
            Vector3 oldPosition = player.transform.position;

            // A. Call Player's 'Move' function
            player.Move(Vector3.right, 10);

            // B. Wait until the end of the frame
            yield return new WaitForFixedUpdate();

            // Get New Position
            Vector3 newPosition = player.transform.position;

            // C. Player's Position should now be different
            Assert.AreNotEqual(oldPosition, newPosition);
        }








        // A Test behaves as an ordinary method
        [UnityTest]
        public IEnumerator SampleTestsSimplePasses()
        {
            // Use the Assert class to test conditions
            yield return null;
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SampleTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
