using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JuhaKurisu.JTween.transform;

namespace JuhaKurisu.JTween
{
    public static class JTweenTransform
    {
        public static Transform JMove(this Transform transform, double Duration)
        {
            JTweenObject obj = JTween.AddJTweenObject(transform.gameObject);

            JTweenTask task = new JTweenTask()
            {
                StartTime = JTween.ElapsedTime,
                Duration = Duration,
                task = new JMove()
            };

            obj.AddTask(task);

            return transform;
        }
    }
}