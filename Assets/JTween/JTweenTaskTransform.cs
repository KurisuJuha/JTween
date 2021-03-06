using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JuhaKurisu.JTween;

namespace JuhaKurisu.JTween.transform
{
    public class JMove : JTweenTaskBase
    {
        public override bool Tween(JTweenTask task, JTweenObject obj, bool over)
        {
            // ここから

            if (over)
            {
                Debug.Log("終わり");
            }
            else
            {
                Debug.Log(JTween.ElapsedTime - task.StartTime);
            }

            // ここまでに処理を書く
            return over;
        }
    }
}