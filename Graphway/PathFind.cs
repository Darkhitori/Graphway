﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace Darkhitori.PlaymakerActions._Graphway
{
    using HutongGames.PlayMaker;

    [ActionCategory("Graphway")]
    [Tooltip("Find a new path from A to B using Graphway.")]
    public class PathFind : FsmStateAction
    {
        [RequiredField]
        [CheckForComponent(typeof(Graphway))]
        public FsmOwnerDefault gameObject;
        
        public FsmGameObject origin;
        
        [Tooltip("End point.")]
        public FsmGameObject targetPosition;
        
        [Tooltip("Clamp final position to closest node.")]
        public FsmBool clampToEndNode;
        
        [Tooltip("Enable Debug Mode to see algorithm in action (slowed down).  ENABLE GIZMOS!")]
        public FsmBool debugMode;
        
        [ActionSection("Waypoints")]
        [Tooltip("The positions of the waypoints.")]
        [UIHint(UIHint.Variable)]
        [ArrayEditor(VariableType.Vector3)]
        public FsmArray positions;
        
        [Tooltip("The speed of each waypoints.")]
        [UIHint(UIHint.Variable)]
        [ArrayEditor(VariableType.Float)]
        public FsmArray speed;
        
        [ActionSection("")]
        public FsmEvent pathEvent;
        
        [Tooltip("Repeat every frame while the state is active.")]
        public bool everyFrame;
        
        Graphway _graph;
        
        public override void Reset()
        {
            gameObject = null;
            origin = null;
            targetPosition = null;
            clampToEndNode = true;
            debugMode = false;
            positions = null;
            speed = null;
            pathEvent = null;
            everyFrame = false;
        }
        
        // Code that runs on entering the state.
        public override void OnEnter()
        {
            DoMethod();
            if (!everyFrame)
            {
                Finish();
            }
        }
        
        public override void OnUpdate()
        {
            DoMethod();
        }

        void DoMethod()
        {
            var go = Fsm.GetOwnerDefaultTarget(gameObject);
            if(go == null)
            {
                return;
            }
            
            _graph = go.GetComponent<Graphway>();
            
            var originPos = origin.Value.transform.position;
            var targetPos = targetPosition.Value.transform.position;
            
            _graph.PathFind(originPos, targetPos, FindPathCallback, clampToEndNode.Value, debugMode.Value);
            
        }
        
        private void FindPathCallback(GwWaypoint[] path)
        {
            // Graphway returns 'null' if no path found
            // OR GwWaypoint array of waypoints to destination
            
            if (path == null)
            {
                Debug.Log("Path to target position not found!");
            }
            else
            {
                positions.Resize(path.Length);
                speed.Resize(path.Length);
                for (int i = 0; i < path.Length; i++) 
                {
                    positions.Set(i, path[i].position);
                    speed.Set(i, path[i].speed);
                }
                
                Fsm.Event(pathEvent);
            }
            
        }


    }

}
