using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public  void getLabels (Mat labels_out)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.SuperpixelSEEDS), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.Mat), "labels_out")]
    public class SuperpixelSEEDS_getLabels : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] SuperpixelSEEDS")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.SuperpixelSEEDS))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject labels_out;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            labels_out = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.SuperpixelSEEDS))
            {
                LogError ("owner is not initialized. Add Action \"newSuperpixelSEEDS\".");
                return;
            }
            OpenCVForUnity.SuperpixelSEEDS wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.SuperpixelSEEDS, OpenCVForUnity.SuperpixelSEEDS> (owner);

            if (!(labels_out.Value is OpenCVForUnityPlayMakerActions.Mat))
            {
                LogError ("labels_out is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.Mat wrapped_labels_out = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.Mat> (labels_out);

            wrapped_owner.getLabels (wrapped_labels_out);


        }

    }

}