﻿using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class WristPoseSubscriber : Subscriber<Messages.Geometry.Pose>
    {
        public GameObject myPrefab;
        public Vector3 position;
        public Quaternion rotation;
        public bool isMessageReceived;

        protected override void Start()
        {
			base.Start();
		}
		
        private void Update()
        {
            //myPrefab.transform.position = position;
            myPrefab.transform.rotation = rotation;
            if (isMessageReceived) {
                ProcessMessage();
            }
        }

        protected override void ReceiveMessage(Messages.Geometry.Pose message)
        {
            position = GetPosition(message).Ros2Unity();
            rotation = GetRotation(message).Ros2Unity();
            isMessageReceived = true;
        }

        private void ProcessMessage()
        {
            //PublishedTransform.position = position;
            //PublishedTransform.rotation = rotation;
        }

        private Vector3 GetPosition(Messages.Geometry.Pose message)
        {
            return new Vector3(
                message.position.x,
                message.position.y,
                message.position.z);
        }

        private Quaternion GetRotation(Messages.Geometry.Pose message)
        {
            return new Quaternion(
                message.orientation.x,
                message.orientation.y,
                message.orientation.z,
                message.orientation.w);
        }
    }
}