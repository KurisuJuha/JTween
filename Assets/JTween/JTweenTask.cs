using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JuhaKurisu.JTween
{
    public class JTweenObject
    {
        public GameObject gameObject;
        public Queue<JTweenTask> Tasks = new Queue<JTweenTask>();

        public void AddTask(JTweenTask task)
        {
            Tasks.Enqueue(task);
        }
    }

    public class JTweenTask
    {
        public double StartTime;
        public double Duration;



        public JTweenTaskBase task;
    }
}