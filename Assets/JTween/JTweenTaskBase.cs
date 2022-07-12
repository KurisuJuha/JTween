using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JTween
{
    public abstract class JTweenTaskBase
    {
        public abstract bool Tween(JTweenTask task, JTweenObject obj, bool over);
    }
}