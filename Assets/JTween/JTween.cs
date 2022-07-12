using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JTween
{
    public class JTween : JtweenSingletonMonoBehaviour<JTween>
    {
        public Dictionary<int, JTweenObject> JTweenObjects = new Dictionary<int, JTweenObject>();
        public double ElapsedTime = 0d;

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
            // JTweenObjectsのキーを移す
            int[] JTweenObjectsKeys = new int[JTweenObjects.Count];
            int i = 0;

            foreach (int key in JTweenObjects.Keys)
            {
                JTweenObjectsKeys[i] = key;
                i++;
            }

            // 全てのオブジェクトのタスクを実行する。
            foreach (int key in JTweenObjectsKeys)
            {
                JTweenObject currentObject = JTweenObjects[key];

                if (currentObject.Tasks.TryPeek(out JTweenTask JTweenTask))
                {
                    if (JTweenTask.task.Tween(0, currentObject))
                    {
                        currentObject.Tasks.Dequeue();
                    }
                }
            }
        }
    }

}