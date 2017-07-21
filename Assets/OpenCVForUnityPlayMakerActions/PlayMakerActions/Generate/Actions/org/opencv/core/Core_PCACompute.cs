using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public static void PCACompute (Mat data, Mat mean, Mat eigenvectors, double retainedVariance)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "data")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "mean")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "eigenvectors")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Double), "retainedVariance")]
    public class Core_PCACompute : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject data;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject mean;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject eigenvectors;

        [HutongGames.PlayMaker.ActionSection ("[arg4] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject retainedVariance;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            data = null;
            mean = null;
            eigenvectors = null;
            retainedVariance = null;
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

            if (!(data.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("data is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_data = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (data);

            if (!(mean.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("mean is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_mean = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (mean);

            if (!(eigenvectors.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("eigenvectors is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_eigenvectors = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (eigenvectors);

            if (!(retainedVariance.Value is OpenCVForUnityPlayMakerActions.Double))
            {
                LogError ("retainedVariance is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_retainedVariance = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Double, System.Double> (retainedVariance);

            OpenCVForUnity.Core.PCACompute (wrapped_data, wrapped_mean, wrapped_eigenvectors, wrapped_retainedVariance);


        }

    }

}