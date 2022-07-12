using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JTweenTransform
{
    public static Transform JMove(this Transform transform)
    {
        JTweenObject obj = JTween.AddJTweenObject(transform.gameObject);

        

        return transform;
    }
}
