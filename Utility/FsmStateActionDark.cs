using UnityEngine;

namespace Darkhitori.PlaymakerActions
{
    using HutongGames.PlayMaker;
    
    public abstract class FsmStateActionDark : FsmStateAction
    {
        public enum FrameUpdateSelector 
        {
            OnUpdate,
            OnLateUpdate,
            OnFixedUpdate
        };

        [ActionSection("Update type")]
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;
        
        public FrameUpdateSelector updateType;
        
        
        public abstract void OnActionUpdate();
        
        public override void Reset()
        {
            everyFrame = false;
            updateType = FrameUpdateSelector.OnUpdate;
        }

        public override void OnPreprocess()
        {
            if (updateType == FrameUpdateSelector.OnFixedUpdate)
            {
                Fsm.HandleFixedUpdate = true;
            }
            
            #if PLAYMAKER_1_8_5_OR_NEWER
            if (updateType == FrameUpdateSelector.OnLateUpdate)
            {
                Fsm.HandleLateUpdate = true;
            }
            #endif
        }

        
        public override void OnUpdate()
        {
            if (updateType == FrameUpdateSelector.OnUpdate)
            {
                OnActionUpdate();
            }
            
            if (!everyFrame)
            {
                Finish();
            }
        }
        
        public override void OnLateUpdate()
        {
            if (updateType == FrameUpdateSelector.OnLateUpdate)
            {
                OnActionUpdate();
            }

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnFixedUpdate()
        {
            if (updateType == FrameUpdateSelector.OnFixedUpdate)
            {
                OnActionUpdate();
            }

            if (!everyFrame)
            {
                Finish();
            }
        }
        
    }
}