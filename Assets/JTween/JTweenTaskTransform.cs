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
            // ��������

            if (over)
            {
                Debug.Log("�I���");
            }
            else
            {
                Debug.Log(JTween.ElapsedTime - task.StartTime);
            }

            // �����܂łɏ���������
            return over;
        }
    }
}