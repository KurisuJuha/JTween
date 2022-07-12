using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JTween
{
    public abstract class JTweenTaskBase
    {
        public abstract bool Tween(float per, JTweenObject obj);
    }

    public class JTweenTaskTest : JTweenTaskBase
    {
        public override bool Tween(float per, JTweenObject obj)
        {
            Debug.Log("testTask");

            return true;
        }
    }
}