using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static double findTransformECC (Mat templateImage, Mat inputImage, Mat warpMatrix, int motionType, TermCriteria criteria, Mat inputMask)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "templateImage")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "inputImage")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "warpMatrix")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "motionType")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.TermCriteria), "criteria")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "inputMask")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "storeResult")]
    public class Video_findTransformECC_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject templateImage;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject inputImage;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject warpMatrix;

        [HutongGames.PlayMaker.ActionSection ("[arg4] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt motionType;

        [HutongGames.PlayMaker.ActionSection ("[arg5] TermCriteria")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.TermCriteria))]
        public HutongGames.PlayMaker.FsmObject criteria;

        [HutongGames.PlayMaker.ActionSection ("[arg6] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject inputMask;

        [HutongGames.PlayMaker.ActionSection ("[return] double(float)")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            templateImage = null;
            inputImage = null;
            warpMatrix = null;
            motionType = 0;
            criteria = null;
            inputMask = null;
            storeResult = null;
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

            if (!(templateImage.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("templateImage is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_templateImage = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (templateImage);

            if (!(inputImage.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("inputImage is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_inputImage = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (inputImage);

            if (!(warpMatrix.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("warpMatrix is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_warpMatrix = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (warpMatrix);

            if (!(criteria.Value is OpenCVForUnityPlayMakerActions.TermCriteria))
            {
                LogError ("criteria is not initialized. Add Action \"newTermCriteria\".");
                return;
            }
            OpenCVForUnity.TermCriteria wrapped_criteria = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.TermCriteria, OpenCVForUnity.TermCriteria> (criteria);

            if (!(inputMask.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("inputMask is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_inputMask = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (inputMask);

            storeResult.Value = (float)OpenCVForUnity.Video.findTransformECC (wrapped_templateImage, wrapped_inputImage, wrapped_warpMatrix, motionType.Value, wrapped_criteria, wrapped_inputMask);


        }

    }

}