using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.ShapeModule;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity_shape")]
    [HutongGames.PlayMaker.Tooltip ("public void warpImage (Mat transformingImage, Mat output, int flags, int borderMode, Scalar borderValue)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.ShapeTransformer), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "transformingImage")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "output")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "flags")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "borderMode")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Scalar), "borderValue")]
    public class ShapeTransformer_warpImage : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] ShapeTransformer")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.ShapeTransformer))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject transformingImage;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject output;

        [HutongGames.PlayMaker.ActionSection ("[arg3] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt flags;

        [HutongGames.PlayMaker.ActionSection ("[arg4] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt borderMode;

        [HutongGames.PlayMaker.ActionSection ("[arg5] Scalar")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Scalar))]
        public HutongGames.PlayMaker.FsmObject borderValue;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            transformingImage = null;
            output = null;
            flags = 0;
            borderMode = 0;
            borderValue = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.ShapeTransformer))
            {
                LogError ("owner is not initialized. Add Action \"newShapeTransformer\".");
                return;
            }
            OpenCVForUnity.ShapeModule.ShapeTransformer wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.ShapeTransformer, OpenCVForUnity.ShapeModule.ShapeTransformer> (owner);

            if (!(transformingImage.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("transformingImage is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_transformingImage = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (transformingImage);

            if (!(output.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("output is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_output = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (output);

            if (!(borderValue.Value is OpenCVForUnityPlayMakerActions.Scalar))
            {
                LogError ("borderValue is not initialized. Add Action \"newScalar\".");
                return;
            }
            OpenCVForUnity.CoreModule.Scalar wrapped_borderValue = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Scalar, OpenCVForUnity.CoreModule.Scalar> (borderValue);

            wrapped_owner.warpImage (wrapped_transformingImage, wrapped_output, flags.Value, borderMode.Value, wrapped_borderValue);


        }

    }

}