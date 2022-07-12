using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JTween
{
    public static class JTweenTransform
    {
        public static Transform JMove(this Transform transform)
        {
            JTweenObject obj = JTween.AddJTweenObject(transform.gameObject);

            obj.AddTask(new JTweenTask()
            {
                task = new JTweenTaskTest()
            });

            return transform;
        }
    }

}