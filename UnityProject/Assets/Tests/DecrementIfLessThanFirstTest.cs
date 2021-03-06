﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class DecrementIfLessThanFirstTest
    {
        [Test]
        public void DecrementIfLessThanFirstSimplePasses()
        {
            int[] input = { 4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = DecrementIfLessThanFirstFilter.decrementIfLessThanFirst(input);
            int[] expected = { 4, 1, 8, 2, 9, 4, 10, 5, 11, 6, 0 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }

        [Test]
        public void DecrementIfLessThanFirstMinusTest()
        {
            int[] input = { -4, -2, -8, -3, -9, -4, -10, -5, -11, -6, -1 };
            int[] output = DecrementIfLessThanFirstFilter.decrementIfLessThanFirst(input);
            int[] expected = { -4, -2, -9, -3, -10, -4, -11, -6, -12, -7, -1 };

            foreach (var o in output)
            {
                Debug.Log(o);
            }

            CollectionAssert.AreEqual(expected, output);
        }

    }
}
