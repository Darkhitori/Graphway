using HutongGames.PlayMaker;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Darkhitori.PlaymakerActions
{
    /// <summary>
    /// A collection of helper functions and extensions for custom actions.
    /// </summary>
    public static class PlayMakerDarkHelpers
    {
        #region Converter
        /////////////////
        
        /******************************
        ********** FsmGameobject **********
        ******************************/
        
        public static List<GameObject> GameobjectToList(this FsmArray fsmGameobject)
        {
            List<GameObject> result = new List<GameObject>();

            for(int i = 0; i < fsmGameobject.Length; i++)
            {
                result.Add((GameObject)fsmGameobject.Values[i]);
            }
            
            return result;
        }
        
        public static List<Vector3> GameobjectToVec3List(this FsmArray fsmGameobject)
        {
            List<Vector3> result = new List<Vector3>();

            for(int i = 0; i < fsmGameobject.Length; i++)
            {
                var v3Pos = (GameObject)fsmGameobject.Values[i];
                result.Add(v3Pos.transform.position);
            }
            
            return result;
        }
        
        public static List<Transform> GameobjectToTransList(this FsmArray fsmGameobject)
        {
            List<Transform> result = new List<Transform>();

            for(int i = 0; i < fsmGameobject.Length; i++)
            {
                var trans = (GameObject)fsmGameobject.Values[i];
                result.Add(trans.transform);
            }
            
            return result;
        }
        
        public static GameObject[] GameobjectToArray(this FsmArray fsmGameobject)
        {
            GameObject[] result = new GameObject[fsmGameobject.Length];

            for(int i = 0; i < fsmGameobject.Length; i++)
            {
                result[i] = (GameObject)fsmGameobject.Values[i];
            }
            
            return result;
        }
        
        public static Vector3[] GameobjectToVec3Array(this FsmArray fsmGameobject)
        {
            Vector3[] result = new Vector3[fsmGameobject.Length];

            for(int i = 0; i < fsmGameobject.Length; i++)
            {
                var v3Pos = (GameObject)fsmGameobject.Values[i];
                result[i] = v3Pos.transform.position;
            }
            
            return result;
        }
        
        public static Transform[] GameobjectToTranArray(this FsmArray fsmGameobject)
        {
            Transform[] result = new Transform[fsmGameobject.Length];

            for(int i = 0; i < fsmGameobject.Length; i++)
            {
                var trans = (GameObject)fsmGameobject.Values[i];
                result[i] = trans.transform;
            }
            
            return result;
        }
        
        /******************************
        ********** FsmBool **********
        ******************************/
        
        public static List<bool> BoolToList(this FsmArray fsmBool)
        {
            return fsmBool.boolValues.ToList();
        }
        
        public static bool[] BoolToArray(this FsmArray fsmBool)
        {
            return fsmBool.boolValues;
        }
        
        /******************************
        ********** FsmInt **********
        ******************************/
        
        public static List<int> IntToList(this FsmArray fsmInt)
        {
            return fsmInt.intValues.ToList();
        }
        
        public static int[] IntToArray(this FsmArray fsmInt)
        {
            return fsmInt.intValues;
        }
        
        /******************************
        ********** FsmFloat **********
        ******************************/
        
        public static List<float> FloatToList(this FsmArray fsmFloat)
        {
            return fsmFloat.floatValues.ToList();
        }
        
        public static float[] FloatToArray(this FsmArray fsmFloat)
        {
            return fsmFloat.floatValues;
        }
        
        /******************************
        ********** FsmVector2**********
        ******************************/
        
        public static List<Vector2> Vec2ToList(this FsmArray fsmVector2)
        {
            List<Vector2> result = new List<Vector2>();

            for(int i = 0; i < fsmVector2.Length; i++)
            {
                result.Add((Vector2)fsmVector2.Values[i]);
            }
            
            return result;
        }
        
        public static Vector2[] Vec2ToArray(this FsmArray fsmVector2)
        {
            Vector2[] result = new Vector2[fsmVector2.Length];

            for(int i = 0; i < fsmVector2.Length; i++)
            {
                result[i] = (Vector2)fsmVector2.Values[i];
            }
            
            return result;
        }
        
        /******************************
        ********** FsmVector3**********
        ******************************/
        
        public static List<Vector3> Vec3ToList(this FsmArray fsmVector3)
        {
            List<Vector3> result = new List<Vector3>();

            for(int i = 0; i < fsmVector3.Length; i++)
            {
                result.Add((Vector3)fsmVector3.Values[i]);
            }
            
            return result;
        }
        
        public static Vector3[] Vec3ToArray(this FsmArray fsmVector3)
        {
            Vector3[] result = new Vector3[fsmVector3.Length];

            for(int i = 0; i < fsmVector3.Length; i++)
            {
                result[i] = (Vector3)fsmVector3.Values[i];
            }
            
            return result;
        }

        /******************************
        ********** FsmString **********
        ******************************/

        public static List<string> StringToList(this FsmArray fsmString)
        {
            return fsmString.stringValues.ToList();
        }

        public static string[] StringToArray(this FsmArray fsmString)
        {
            return fsmString.stringValues;
        }
        
        /******************************
        ********** FsmVector4 **********
        ******************************/

        public static List<Vector4> Vec4ToList(this FsmArray fsmVector4)
        {
            return fsmVector4.vector4Values.ToList();
        }

        public static Vector4[] Vec4ToArray(this FsmArray fsmVector4)
        {
            return fsmVector4.vector4Values;
        }
        
        /******************************
        ********** FsmMonoBehaviour **********
        ******************************/
        
        public static List<MonoBehaviour> MonoToList(this FsmArray fsmMono)
        {
            List<MonoBehaviour> result = new List<MonoBehaviour>();

            for(int i = 0; i < fsmMono.Length; i++)
            {
                result.Add((MonoBehaviour)fsmMono.Values[i]);
            }
            
            return result;
        }
        
        public static MonoBehaviour[] MonoToArray(this FsmArray fsmMono)
        {
            MonoBehaviour[] result = new MonoBehaviour[fsmMono.Length];

            for(int i = 0; i < fsmMono.Length; i++)
            {
                result[i] = (MonoBehaviour)fsmMono.Values[i];
            }
            
            return result;
        }
        
        /******************************
        ********** FsmAnimationClip **********
        ******************************/
        
        public static List<AnimationClip> AnimClipToList(this FsmArray fsmAnimClip)
        {
            List<AnimationClip> result = new List<AnimationClip>();

            for(int i = 0; i < fsmAnimClip.Length; i++)
            {
                result.Add((AnimationClip)fsmAnimClip.Values[i]);
            }
            
            return result;
        }
        
        public static AnimationClip[] AnimClipToArray(this FsmArray fsmAnimClip)
        {
            AnimationClip[] result = new AnimationClip[fsmAnimClip.Length];

            for(int i = 0; i < fsmAnimClip.Length; i++)
            {
                result[i] = (AnimationClip)fsmAnimClip.Values[i];
            }
            
            return result;
        }
        
        /******************************
        ********** FsmBehaviour **********
        ******************************/
        
        public static List<Behaviour> BehavToList(this FsmArray fsmBehaviour)
        {
            List<Behaviour> result = new List<Behaviour>();

            for(int i = 0; i < fsmBehaviour.Length; i++)
            {
                result.Add((Behaviour)fsmBehaviour.Values[i]);
            }
            
            return result;
        }
        
        public static Behaviour[] BehavToArray(this FsmArray fsmBehaviour)
        {
            Behaviour[] result = new Behaviour[fsmBehaviour.Length];

            for(int i = 0; i < fsmBehaviour.Length; i++)
            {
                result[i] = (Behaviour)fsmBehaviour.Values[i];
            }
            
            return result;
        }
        
        /******************************
        ********** FsmAudioClip **********
        ******************************/
        
        public static List<AudioClip> AudioClipToList(this FsmArray fsmAudioClip)
        {
            List<AudioClip> result = new List<AudioClip>();

            for(int i = 0; i < fsmAudioClip.Length; i++)
            {
                result.Add((AudioClip)fsmAudioClip.Values[i]);
            }
            
            return result;
        }
        
        public static AudioClip[] AudioClipToArray(this FsmArray fsmAudioClip)
        {
            AudioClip[] result = new AudioClip[fsmAudioClip.Length];

            for(int i = 0; i < fsmAudioClip.Length; i++)
            {
                result[i] = (AudioClip)fsmAudioClip.Values[i];
            }
            
            return result;
        }
        /******************************
        ********** FsmAudioSource **********
        ******************************/
        
        public static List<AudioSource> AudioSourceToList(this FsmArray fsmAudioSource)
        {
            List<AudioSource> result = new List<AudioSource>();

            for(int i = 0; i < fsmAudioSource.Length; i++)
            {
                result.Add((AudioSource)fsmAudioSource.Values[i]);
            }
            
            return result;
        }
        
        public static AudioSource[] AudioSourceToArray(this FsmArray fsmAudioSource)
        {
            AudioSource[] result = new AudioSource[fsmAudioSource.Length];

            for(int i = 0; i < fsmAudioSource.Length; i++)
            {
                result[i] = (AudioSource)fsmAudioSource.Values[i];
            }
            
            return result;
        }
        
        /******************************
        ********** FsmCollider **********
        ******************************/
        
        public static List<Collider> ColliderToList(this FsmArray fsmCollider)
        {
            List<Collider> result = new List<Collider>();

            for(int i = 0; i < fsmCollider.Length; i++)
            {
                result.Add((Collider)fsmCollider.Values[i]);
            }
            
            return result;
        }
        
        public static Collider[] ColliderToArray(this FsmArray fsmCollider)
        {
            Collider[] result = new Collider[fsmCollider.Length];

            for(int i = 0; i < fsmCollider.Length; i++)
            {
                result[i] = (Collider)fsmCollider.Values[i];
            }
            
            return result;
        }
        
        /******************************
        ********** FsmCollider2D **********
        ******************************/
        
        public static List<Collider2D> Collider2DToList(this FsmArray fsmCollider2D)
        {
            List<Collider2D> result = new List<Collider2D>();

            for(int i = 0; i < fsmCollider2D.Length; i++)
            {
                result.Add((Collider2D)fsmCollider2D.Values[i]);
            }
            
            return result;
        }
        
        public static Collider2D[] Collider2DToArray(this FsmArray fsmCollider2D)
        {
            Collider2D[] result = new Collider2D[fsmCollider2D.Length];

            for(int i = 0; i < fsmCollider2D.Length; i++)
            {
                result[i] = (Collider2D)fsmCollider2D.Values[i];
            }
            
            return result;
        }
        
        /******************************
        ********** FsmRenderer **********
        ******************************/
        
        public static List<Renderer> RendererToList(this FsmArray fsmRenderer)
        {
            List<Renderer> result = new List<Renderer>();

            for(int i = 0; i < fsmRenderer.Length; i++)
            {
                result.Add((Renderer)fsmRenderer.Values[i]);
            }
            
            return result;
        }
        
        public static Renderer[] RendererToArray(this FsmArray fsmRenderer)
        {
            Renderer[] result = new Renderer[fsmRenderer.Length];

            for(int i = 0; i < fsmRenderer.Length; i++)
            {
                result[i] = (Renderer)fsmRenderer.Values[i];
            }
            
            return result;
        }
        
        /******************************
        ********** FsmMaterial **********
        ******************************/
        
        public static List<Material> MaterialToList(this FsmArray fsmMaterial)
        {
            List<Material> result = new List<Material>();

            for(int i = 0; i < fsmMaterial.Length; i++)
            {
                result.Add((Material)fsmMaterial.Values[i]);
            }
            
            return result;
        }
        
        public static Material[] MaterialToArray(this FsmArray fsmMaterial)
        {
            Material[] result = new Material[fsmMaterial.Length];

            for(int i = 0; i < fsmMaterial.Length; i++)
            {
                result[i] = (Material)fsmMaterial.Values[i];
            }
            
            return result;
        }
        /******************************
        ********** FsmTransform **********
        ******************************/
        
        public static List<Transform> TransformToList(this FsmArray fsmTransform)
        {
            List<Transform> result = new List<Transform>();

            for(int i = 0; i < fsmTransform.Length; i++)
            {
                result.Add((Transform)fsmTransform.Values[i]);
            }
            
            return result;
        }
        
        public static Transform[] TransformToArray(this FsmArray fsmTransform)
        {
            Transform[] result = new Transform[fsmTransform.Length];

            for(int i = 0; i < fsmTransform.Length; i++)
            {
                result[i] = (Transform)fsmTransform.Values[i];
            }
            
            return result;
        }
        
        #endregion
    }
}