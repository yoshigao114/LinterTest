using InfallibleCode;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class DirectionTests
    {
        [Test]
        public void North()
        {
            Assert.AreEqual(new Vector3(0, 1, 0), Direction.North.Vector);
        }
    }
}
