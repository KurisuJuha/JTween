using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JTween : JtweenSingletonMonoBehaviour<JTween>
{
    public Dictionary<int, JTweenObject> JTweenObjects = new Dictionary<int, JTweenObject>();

    public static JTweenObject AddJTweenObject(GameObject gameObject)
    {
        JTweenObject obj = new JTweenObject()
        {
            gameObject = gameObject
        };

        Instance.JTweenObjects[gameObject.GetInstanceID()] = obj;

        return obj;
    }

    [RuntimeInitializeOnLoadMethod]
    private static void Initialize()
    {
        GameObject obj = new GameObject("JTween", typeof(JTween));
        DontDestroyOnLoad(obj);
    }

    private void Update()
    {
        
    }
}
