using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace Darkhitori.PlaymakerActions._Graphway
{
    using HutongGames.PlayMaker;

    [ActionCategory("Graphway")]
    [Tooltip("Resets pathfinding var state when finding a new path")]
    public class ResetPathfindingVars : FsmStateAction
    {
        [RequiredField]
        [CheckForComponent(typeof(Graphway))]
        public FsmOwnerDefault gameObject;
        
        [Tooltip("The ID of the node connection is coming from.  Same as node GameObject name.")]
        public FsmInt nodeID;
        
        [Tooltip("Repeat every frame while the state is active.")]
        public bool everyFrame;
        
        Graphway _graph;
        
        public override void Reset()
        {
            gameObject = null;
            nodeID = null;
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
            
            _graph.nodes[nodeID.Value].ResetPathfindingVars();
            
        }
    }

}
