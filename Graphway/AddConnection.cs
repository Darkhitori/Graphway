using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace Darkhitori.PlaymakerActions._Graphway
{
    using HutongGames.PlayMaker;

    [ActionCategory("Graphway")]
    [Tooltip("Add a new connection from this node to another.")]
    public class AddConnection : FsmStateAction
    {
        [RequiredField]
        [CheckForComponent(typeof(Graphway))]
        public FsmOwnerDefault gameObject;
        
        [Tooltip("The ID of the node connection is coming from.  Same as node GameObject name.")]
        public FsmInt nodeID;
        
        [Tooltip("The ID of the connected node.  Same as node GameObject name.")]
        public FsmInt connectedNodeID;
        
        [Tooltip("Connection is enabled/disabled by default.")]
        public FsmBool disabled;
        
        [Tooltip("Speed weight score of connection.")]
        public FsmFloat speedWeight;
        
        [Tooltip("Array of subnode positions, closest to furthest.")]
        [ArrayEditor(VariableType.GameObject)]
        public FsmArray subnodes;
        
        [Tooltip("Repeat every frame while the state is active.")]
        public bool everyFrame;
        
        Graphway _graph;
        
        public override void Reset()
        {
            gameObject = null;
            nodeID = null;
            connectedNodeID = null;
            disabled = false;
            speedWeight = null;
            subnodes = null;
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
            
            _graph.nodes[nodeID.Value].AddConnection(connectedNodeID.Value, disabled.Value, speedWeight.Value, subnodes.GameobjectToVec3Array());
            
        }
    }

}
