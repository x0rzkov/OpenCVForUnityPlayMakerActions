using UnityEngine;
using System.Collections.Generic;

using OpenCVForUnity;


namespace OpenCVForUnityPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("OpenCVForUnity")]
    [HutongGames.PlayMaker.Tooltip ("public int getNormFlag ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (OpenCVForUnityPlayMakerActions.NormHistogramCostExtractor), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmInt), "storeResult")]
    public class NormHistogramCostExtractor_getNormFlag : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] NormHistogramCostExtractor")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (OpenCVForUnityPlayMakerActions.NormHistogramCostExtractor))]
        public HutongGames.PlayMaker.FsmObject owner;

        [HutongGames.PlayMaker.ActionSection ("[return] int")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool everyFrame;

        public override void Reset ()
        {
            owner = null;
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

            if (!(owner.Value is OpenCVForUnityPlayMakerActions.NormHistogramCostExtractor))
            {
                LogError ("owner is not initialized. Add Action \"newNormHistogramCostExtractor\".");
                return;
            }
            OpenCVForUnity.NormHistogramCostExtractor wrapped_owner = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.NormHistogramCostExtractor, OpenCVForUnity.NormHistogramCostExtractor> (owner);

            storeResult.Value = wrapped_owner.getNormFlag ();


        }

    }

}
