using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace Darkhitori.PlaymakerActions._Graphway
{
    using HutongGames.PlayMaker;

    [ActionCategory("Graphway")]
    [Tooltip("Update connection speed weight property.")]
    public class SetConnectionSpeedWeight : FsmStateAction
    {
        [RequiredField]
        [CheckForComponent(typeof(Graphway))]
        public FsmOwnerDefault gameObject;
        
        [Tooltip("The ID of the node connection is coming from.  Same as node GameObject name.")]
        public FsmInt nodeID;
        
        [Tooltip("The ID of the connected node.  Same as node GameObject name.")]
        public FsmInt nodeToID;
        
        [Tooltip("New speed weight setting")]
        public FsmFloat speedWeight;
        
        [Tooltip("Repeat every frame while the state is active.")]
        public bool everyFrame;
        
        Graphway _graph;
        
        public override void Reset()
        {
            gameObject = null;
            nodeID = null;
            nodeToID = null;
            speedWeight = null;
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
            
            _graph.nodes[nodeID.Value].SetConnectionSpeedWeight(nodeToID.Value, speedWeight.Value);
            
        }
    }

}
