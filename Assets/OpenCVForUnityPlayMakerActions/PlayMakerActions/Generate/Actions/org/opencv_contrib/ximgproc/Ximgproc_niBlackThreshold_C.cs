using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static void niBlackThreshold (Mat _src, Mat _dst, double maxValue, int type, int blockSize, double delta)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "_src")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "_dst")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "maxValue")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "type")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "blockSize")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "delta")]
    public class Ximgproc_niBlackThreshold_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject _src;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject _dst;

        [HutongGames.PlayMaker.ActionSection ("[arg3] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat maxValue;

        [HutongGames.PlayMaker.ActionSection ("[arg4] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt type;

        [HutongGames.PlayMaker.ActionSection ("[arg5] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt blockSize;

        [HutongGames.PlayMaker.ActionSection ("[arg6] double(float)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat delta;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            _src = null;
            _dst = null;
            maxValue = 0.0f;
            type = 0;
            blockSize = 0;
            delta = 0.0f;
            everyFrame = false;
        }

        public override void OnEnter ()
        {
            DoProcess ();

            if (!everyFrame)
            {
                Finish ();
            }
        }

        public override void OnUpdate ()
        {
            DoProcess ();
        }

        void DoProcess ()
        {

            if (!(_src.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("_src is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped__src = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (_src);

            if (!(_dst.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("_dst is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped__dst = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (_dst);

            OpenCVForUnity.Ximgproc.niBlackThreshold (wrapped__src, wrapped__dst, (float)maxValue.Value, type.Value, blockSize.Value, (float)delta.Value);


        }

    }

}
