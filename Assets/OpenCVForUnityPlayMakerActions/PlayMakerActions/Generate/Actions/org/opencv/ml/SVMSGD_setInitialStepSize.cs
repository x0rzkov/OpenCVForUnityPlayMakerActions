using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public  void setInitialStepSize (float InitialStepSize)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.SVMSGD), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "InitialStepSize")]
    public class SVMSGD_setInitialStepSize : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] SVMSGD")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.SVMSGD))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat InitialStepSize;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
            InitialStepSize = 0.0f;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.SVMSGD))
            {
                LogError ("owner is not initialized. Add Action \"newSVMSGD\".");
                return;
            }
            OpenCVForUnity.SVMSGD wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.SVMSGD, OpenCVForUnity.SVMSGD> (owner);

            wrapped_owner.setInitialStepSize (InitialStepSize.Value);


        }

    }

}
