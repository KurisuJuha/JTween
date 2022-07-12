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
            // ‚±‚±‚©‚ç

            if (over)
            {
                Debug.Log("I‚í‚è");
            }
            else
            {
                Debug.Log(JTween.ElapsedTime - task.StartTime);
            }

            // ‚±‚±‚Ü‚Å‚Éˆ—‚ğ‘‚­
            return over;
        }
    }
}