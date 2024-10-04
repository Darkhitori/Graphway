using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace Darkhitori.PlaymakerActions._Graphway
{
	using HutongGames.PlayMaker;

	[ActionCategory("Graphway")]
	[Tooltip("Number of nodes that can be checked in a single frame at runtime.  A higher limit will find paths faster, but may impact performance.")]
	public class PathfindFrameLimit : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(Graphway))]
		public FsmOwnerDefault gameObject;
        
		public FsmInt pathfindFrameLimit;
        
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
        
		Graphway _graph;
        
		public override void Reset()
		{
			gameObject = null;
			pathfindFrameLimit = 100;
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
            
			_graph.pathfindFrameLimit = pathfindFrameLimit.Value;
            
		}
		
	}

}
