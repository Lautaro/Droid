//----------------------------------------------
//            iTweenExtension
// Copyright © 2013 Mobile Petroleum
//----------------------------------------------


using UnityEngine;
using System.Collections;

public static class iTweenExtension
{
    public static void iStop (this GameObject go, string type, bool includeChildren)
    {
        iTween.Stop(go, type, includeChildren);
    }

    public static void iStop (this GameObject go, string type)
    {
        iTween.Stop(go, type);
    }

    public static void iStop (this GameObject go, bool includeChildren)
    {
        iTween.Stop(go, includeChildren);
    }

    public static void iStop (this GameObject go)
    {
        iTween.Stop(go);
    }

    public static void iResume (this GameObject go, string type, bool includeChildren)
    {
        iTween.Resume(go, type, includeChildren);
    }

    public static void iResume (this GameObject go, string type)
    {
        iTween.Resume(go, type);
    }

    public static void iResume (this GameObject go, bool includeChildren)
    {
        iTween.Resume(go, includeChildren);
    }

    public static void iResume (this GameObject go)
    {
        iTween.Resume(go);
    }

    public static void iPause (this GameObject go, string type, bool includeChildren)
    {
        iTween.Pause(go, type, includeChildren);
    }

    public static void iPause (this GameObject go, string type)
    {
        iTween.Pause(go, type);
    }

    public static void iPause (this GameObject go, bool includeChildren)
    {
        iTween.Pause(go, includeChildren);
    }

    public static void iPause (this GameObject go)
    {
        iTween.Pause(go);
    }

    public static void iInit (this GameObject go)
    {
        iTween.Init(go);
    }

    public static int iCount (this GameObject go)
    {
        return iTween.Count(go);
    }

    public static OutgoingAudioFrom iAudioFrom (this GameObject go)
    {
        return new OutgoingAudioFrom(go);
    }

    public static OutgoingAudioTo iAudioTo (this GameObject go)
    {
        return new OutgoingAudioTo(go);
    }

    public static OutgoingAudioUpdate iAudioUpdate (this GameObject go)
    {
        return new OutgoingAudioUpdate(go);
    }

    public static OutgoingCameraFadeFrom iCameraFadeFrom (this GameObject go)
    {
        return new OutgoingCameraFadeFrom();
    }

    public static OutgoingCameraFadeTo iCameraFadeTo (this GameObject go)
    {
        return new OutgoingCameraFadeTo();
    }

    public static OutgoingColorFrom iColorFrom (this GameObject go)
    {
        return new OutgoingColorFrom(go);
    }

    public static OutgoingColorTo iColorTo (this GameObject go)
    {
        return new OutgoingColorTo(go);
    }

    public static OutgoingColorUpdate iColorUpdate (this GameObject go)
    {
        return new OutgoingColorUpdate(go);
    }

    public static OutgoingFadeFrom iFadeFrom (this GameObject go)
    {
        return new OutgoingFadeFrom(go);
    }

    public static OutgoingFadeTo iFadeTo (this GameObject go)
    {
        return new OutgoingFadeTo(go);
    }

    public static OutgoingFadeUpdate iFadeUpdate (this GameObject go)
    {
        return new OutgoingFadeUpdate(go);
    }

    public static OutgoingLookFrom iLookFrom (this GameObject go)
    {
        return new OutgoingLookFrom(go);
    }

    public static OutgoingLookTo iLookTo (this GameObject go)
    {
        return new OutgoingLookTo(go);
    }

    public static OutgoingLookUpdate iLookUpdate (this GameObject go)
    {
        return new OutgoingLookUpdate(go);
    }

    public static OutgoingMoveAdd iMoveAdd (this GameObject go)
    {
        return new OutgoingMoveAdd(go);
    }

    public static OutgoingMoveBy iMoveBy (this GameObject go)
    {
        return new OutgoingMoveBy(go);
    }

    public static OutgoingMoveFrom iMoveFrom (this GameObject go)
    {
        return new OutgoingMoveFrom(go);
    }

    public static OutgoingMoveTo iMoveTo (this GameObject go)
    {
        return new OutgoingMoveTo(go);
    }

    public static OutgoingMoveUpdate iMoveUpdate (this GameObject go)
    {
        return new OutgoingMoveUpdate(go);
    }

    public static OutgoingPunchPosition iPunchPosition (this GameObject go)
    {
        return new OutgoingPunchPosition(go);
    }

    public static OutgoingPunchRotation iPunchRotation (this GameObject go)
    {
        return new OutgoingPunchRotation(go);
    }

    public static OutgoingPunchScale iPunchScale (this GameObject go)
    {
        return new OutgoingPunchScale(go);
    }

    public static OutgoingRotateAdd iRotateAdd (this GameObject go)
    {
        return new OutgoingRotateAdd(go);
    }

    public static OutgoingRotateBy iRotateBy (this GameObject go)
    {
        return new OutgoingRotateBy(go);
    }

    public static OutgoingRotateFrom iRotateFrom (this GameObject go)
    {
        return new OutgoingRotateFrom(go);
    }

    public static OutgoingRotateTo iRotateTo (this GameObject go)
    {
        return new OutgoingRotateTo(go);
    }

    public static OutgoingRotateUpdate iRotateUpdate (this GameObject go)
    {
        return new OutgoingRotateUpdate(go);
    }

    public static OutgoingScaleAdd iScaleAdd (this GameObject go)
    {
        return new OutgoingScaleAdd(go);
    }

    public static OutgoingScaleBy iScaleBy (this GameObject go)
    {
        return new OutgoingScaleBy(go);
    }

    public static OutgoingScaleFrom iScaleFrom (this GameObject go)
    {
        return new OutgoingScaleFrom(go);
    }

    public static OutgoingScaleTo iScaleTo (this GameObject go)
    {
        return new OutgoingScaleTo(go);
    }

    public static OutgoingScaleUpdate iScaleUpdate (this GameObject go)
    {
        return new OutgoingScaleUpdate(go);
    }

    public static OutgoingShakePosition iShakePosition (this GameObject go)
    {
        return new OutgoingShakePosition(go);
    }

    public static OutgoingShakeRotation iShakeRotation (this GameObject go)
    {
        return new OutgoingShakeRotation(go);
    }

    public static OutgoingShakeScale iShakeScale (this GameObject go)
    {
        return new OutgoingShakeScale(go);
    }

    public static OutgoingStab iStab (this GameObject go)
    {
        return new OutgoingStab(go);
    }

    public static OutgoingValueTo iValueTo (this GameObject go)
    {
        return new OutgoingValueTo(go);
    }

}
public class OutgoingAudioFrom
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingAudioFrom (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.AudioFrom(go, args);
    }

    public OutgoingAudioFrom Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingAudioFrom AudioSource(AudioSource audioSource)
    {
        args.Add("audiosource", audioSource);
        return this;
    }
    public OutgoingAudioFrom Volume(float volume)
    {
        args.Add("volume", volume);
        return this;
    }
    public OutgoingAudioFrom Volume(double volume)
    {
        args.Add("volume", volume);
        return this;
    }
    public OutgoingAudioFrom Pitch(float pitch)
    {
        args.Add("pitch", pitch);
        return this;
    }
    public OutgoingAudioFrom Pitch(double pitch)
    {
        args.Add("pitch", pitch);
        return this;
    }
    public OutgoingAudioFrom Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingAudioFrom Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingAudioFrom Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingAudioFrom Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingAudioFrom EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingAudioFrom EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingAudioFrom LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingAudioFrom LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingAudioFrom OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingAudioFrom OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingAudioFrom OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingAudioFrom OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingAudioFrom OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingAudioFrom OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingAudioFrom OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingAudioFrom OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingAudioFrom OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingAudioFrom OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingAudioFrom OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingAudioFrom IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingAudioTo
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingAudioTo (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.AudioTo(go, args);
    }

    public OutgoingAudioTo Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingAudioTo AudioSource(AudioSource audioSource)
    {
        args.Add("audiosource", audioSource);
        return this;
    }
    public OutgoingAudioTo Volume(float volume)
    {
        args.Add("volume", volume);
        return this;
    }
    public OutgoingAudioTo Volume(double volume)
    {
        args.Add("volume", volume);
        return this;
    }
    public OutgoingAudioTo Pitch(float pitch)
    {
        args.Add("pitch", pitch);
        return this;
    }
    public OutgoingAudioTo Pitch(double pitch)
    {
        args.Add("pitch", pitch);
        return this;
    }
    public OutgoingAudioTo Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingAudioTo Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingAudioTo Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingAudioTo Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingAudioTo EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingAudioTo EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingAudioTo LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingAudioTo LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingAudioTo OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingAudioTo OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingAudioTo OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingAudioTo OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingAudioTo OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingAudioTo OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingAudioTo OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingAudioTo OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingAudioTo OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingAudioTo OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingAudioTo OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingAudioTo IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingAudioUpdate
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingAudioUpdate (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.AudioUpdate(go, args);
    }

    public OutgoingAudioUpdate AudioSource(AudioSource audioSource)
    {
        args.Add("audiosource", audioSource);
        return this;
    }
    public OutgoingAudioUpdate Volume(float volume)
    {
        args.Add("volume", volume);
        return this;
    }
    public OutgoingAudioUpdate Volume(double volume)
    {
        args.Add("volume", volume);
        return this;
    }
    public OutgoingAudioUpdate Pitch(float pitch)
    {
        args.Add("pitch", pitch);
        return this;
    }
    public OutgoingAudioUpdate Pitch(double pitch)
    {
        args.Add("pitch", pitch);
        return this;
    }
    public OutgoingAudioUpdate Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingAudioUpdate Time(double time)
    {
        args.Add("time", time);
        return this;
    }

} 

public class OutgoingCameraFadeFrom
{

    private Hashtable args = new Hashtable();

    public void Start ()
    {
        iTween.CameraFadeFrom(args);
    }

    public OutgoingCameraFadeFrom Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingCameraFadeFrom Amount(float amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingCameraFadeFrom Amount(double amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingCameraFadeFrom Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingCameraFadeFrom Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingCameraFadeFrom Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingCameraFadeFrom Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingCameraFadeFrom EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingCameraFadeFrom EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingCameraFadeFrom LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingCameraFadeFrom LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingCameraFadeFrom OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingCameraFadeFrom OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingCameraFadeFrom OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingCameraFadeFrom OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingCameraFadeFrom OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingCameraFadeFrom OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingCameraFadeFrom OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingCameraFadeFrom OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingCameraFadeFrom OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingCameraFadeFrom OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingCameraFadeFrom OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingCameraFadeFrom IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingCameraFadeTo
{
    private Hashtable args = new Hashtable();

    public void Start ()
    {
        iTween.CameraFadeTo(args);
    }

    public OutgoingCameraFadeTo Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingCameraFadeTo Amount(float amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingCameraFadeTo Amount(double amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingCameraFadeTo Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingCameraFadeTo Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingCameraFadeTo Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingCameraFadeTo Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingCameraFadeTo EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingCameraFadeTo EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingCameraFadeTo LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingCameraFadeTo LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingCameraFadeTo OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingCameraFadeTo OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingCameraFadeTo OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingCameraFadeTo OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingCameraFadeTo OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingCameraFadeTo OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingCameraFadeTo OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingCameraFadeTo OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingCameraFadeTo OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingCameraFadeTo OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingCameraFadeTo OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingCameraFadeTo IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingColorFrom
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingColorFrom (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ColorFrom(go, args);
    }

    public OutgoingColorFrom Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingColorFrom Color(Color color)
    {
        args.Add("color", color);
        return this;
    }
    public OutgoingColorFrom R(float r)
    {
        args.Add("r", r);
        return this;
    }
    public OutgoingColorFrom R(double r)
    {
        args.Add("r", r);
        return this;
    }
    public OutgoingColorFrom G(float g)
    {
        args.Add("g", g);
        return this;
    }
    public OutgoingColorFrom G(double g)
    {
        args.Add("g", g);
        return this;
    }
    public OutgoingColorFrom B(float b)
    {
        args.Add("b", b);
        return this;
    }
    public OutgoingColorFrom B(double b)
    {
        args.Add("b", b);
        return this;
    }
    public OutgoingColorFrom A(float a)
    {
        args.Add("a", a);
        return this;
    }
    public OutgoingColorFrom A(double a)
    {
        args.Add("a", a);
        return this;
    }
    public OutgoingColorFrom NamedColorValue(iTween.NamedValueColor namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingColorFrom NamedColorValue(string namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingColorFrom IncludeChildren(bool includeChildren)
    {
        args.Add("includechildren", includeChildren);
        return this;
    }
    public OutgoingColorFrom Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingColorFrom Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingColorFrom Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingColorFrom Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingColorFrom EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingColorFrom EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingColorFrom LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingColorFrom LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingColorFrom OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingColorFrom OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingColorFrom OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingColorFrom OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingColorFrom OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingColorFrom OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingColorFrom OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingColorFrom OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingColorFrom OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingColorFrom OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingColorFrom OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingColorFrom IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingColorTo
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingColorTo (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ColorTo(go, args);
    }

    public OutgoingColorTo Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingColorTo Color(Color color)
    {
        args.Add("color", color);
        return this;
    }
    public OutgoingColorTo R(float r)
    {
        args.Add("r", r);
        return this;
    }
    public OutgoingColorTo R(double r)
    {
        args.Add("r", r);
        return this;
    }
    public OutgoingColorTo G(float g)
    {
        args.Add("g", g);
        return this;
    }
    public OutgoingColorTo G(double g)
    {
        args.Add("g", g);
        return this;
    }
    public OutgoingColorTo B(float b)
    {
        args.Add("b", b);
        return this;
    }
    public OutgoingColorTo B(double b)
    {
        args.Add("b", b);
        return this;
    }
    public OutgoingColorTo A(float a)
    {
        args.Add("a", a);
        return this;
    }
    public OutgoingColorTo A(double a)
    {
        args.Add("a", a);
        return this;
    }
    public OutgoingColorTo NamedColorValue(iTween.NamedValueColor namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingColorTo NamedColorValue(string namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingColorTo IncludeChildren(bool includeChildren)
    {
        args.Add("includechildren", includeChildren);
        return this;
    }
    public OutgoingColorTo Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingColorTo Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingColorTo Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingColorTo Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingColorTo EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingColorTo EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingColorTo LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingColorTo LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingColorTo OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingColorTo OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingColorTo OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingColorTo OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingColorTo OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingColorTo OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingColorTo OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingColorTo OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingColorTo OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingColorTo OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingColorTo OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingColorTo IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingColorUpdate
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingColorUpdate (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ColorUpdate(go, args);
    }

    public OutgoingColorUpdate Color(Color color)
    {
        args.Add("color", color);
        return this;
    }
    public OutgoingColorUpdate R(float r)
    {
        args.Add("r", r);
        return this;
    }
    public OutgoingColorUpdate R(double r)
    {
        args.Add("r", r);
        return this;
    }
    public OutgoingColorUpdate G(float g)
    {
        args.Add("g", g);
        return this;
    }
    public OutgoingColorUpdate G(double g)
    {
        args.Add("g", g);
        return this;
    }
    public OutgoingColorUpdate B(float b)
    {
        args.Add("b", b);
        return this;
    }
    public OutgoingColorUpdate B(double b)
    {
        args.Add("b", b);
        return this;
    }
    public OutgoingColorUpdate A(float a)
    {
        args.Add("a", a);
        return this;
    }
    public OutgoingColorUpdate A(double a)
    {
        args.Add("a", a);
        return this;
    }
    public OutgoingColorUpdate NamedColorValue(string namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingColorUpdate NamedColorValue(iTween.NamedValueColor namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingColorUpdate IncludeChildren(bool includeChildren)
    {
        args.Add("includechildren", includeChildren);
        return this;
    }
    public OutgoingColorUpdate Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingColorUpdate Time(double time)
    {
        args.Add("time", time);
        return this;
    }

} 

public class OutgoingFadeFrom
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingFadeFrom (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.FadeFrom(go, args);
    }

    public OutgoingFadeFrom Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingFadeFrom Alpha(float alpha)
    {
        args.Add("alpha", alpha);
        return this;
    }
    public OutgoingFadeFrom Alpha(double alpha)
    {
        args.Add("alpha", alpha);
        return this;
    }
    public OutgoingFadeFrom Amount(float amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingFadeFrom Amount(double amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingFadeFrom IncludeChildren(bool includeChildren)
    {
        args.Add("includechildren", includeChildren);
        return this;
    }
    public OutgoingFadeFrom NamedColorValue(string namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingFadeFrom NamedColorValue(iTween.NamedValueColor namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingFadeFrom Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingFadeFrom Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingFadeFrom Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingFadeFrom Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingFadeFrom EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingFadeFrom EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingFadeFrom LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingFadeFrom LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingFadeFrom OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingFadeFrom OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingFadeFrom OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingFadeFrom OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingFadeFrom OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingFadeFrom OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingFadeFrom OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingFadeFrom OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingFadeFrom OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingFadeFrom OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingFadeFrom OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingFadeFrom IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingFadeTo
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingFadeTo (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.FadeTo(go, args);
    }

    public OutgoingFadeTo Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingFadeTo Alpha(float alpha)
    {
        args.Add("alpha", alpha);
        return this;
    }
    public OutgoingFadeTo Alpha(double alpha)
    {
        args.Add("alpha", alpha);
        return this;
    }
    public OutgoingFadeTo Amount(float amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingFadeTo Amount(double amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingFadeTo IncludeChildren(bool includeChildren)
    {
        args.Add("includechildren", includeChildren);
        return this;
    }
    public OutgoingFadeTo NamedColorValue(string namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingFadeTo NamedColorValue(iTween.NamedValueColor namedColorValue)
    {
        args.Add("namedcolorvalue", namedColorValue);
        return this;
    }
    public OutgoingFadeTo Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingFadeTo Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingFadeTo Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingFadeTo Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingFadeTo EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingFadeTo EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingFadeTo LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingFadeTo LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingFadeTo OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingFadeTo OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingFadeTo OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingFadeTo OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingFadeTo OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingFadeTo OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingFadeTo OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingFadeTo OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingFadeTo OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingFadeTo OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingFadeTo OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingFadeTo IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingFadeUpdate
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingFadeUpdate (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.FadeUpdate(go, args);
    }

    public OutgoingFadeUpdate Alpha(float alpha)
    {
        args.Add("alpha", alpha);
        return this;
    }
    public OutgoingFadeUpdate Alpha(double alpha)
    {
        args.Add("alpha", alpha);
        return this;
    }
    public OutgoingFadeUpdate IncludeChildren(bool includeChildren)
    {
        args.Add("includechildren", includeChildren);
        return this;
    }
    public OutgoingFadeUpdate Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingFadeUpdate Time(double time)
    {
        args.Add("time", time);
        return this;
    }

} 

public class OutgoingLookFrom
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingLookFrom (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.LookFrom(go, args);
    }

    public OutgoingLookFrom Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingLookFrom LookTarget(Transform lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingLookFrom LookTarget(Vector3 lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingLookFrom Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingLookFrom Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingLookFrom Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingLookFrom Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingLookFrom Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingLookFrom Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingLookFrom Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingLookFrom EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingLookFrom EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingLookFrom LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingLookFrom LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingLookFrom OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingLookFrom OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingLookFrom OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingLookFrom OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingLookFrom OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingLookFrom OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingLookFrom OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingLookFrom OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingLookFrom OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingLookFrom OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingLookFrom OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingLookFrom IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingLookTo
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingLookTo (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.LookTo(go, args);
    }

    public OutgoingLookTo Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingLookTo LookTarget(Transform lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingLookTo LookTarget(Vector3 lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingLookTo Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingLookTo Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingLookTo Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingLookTo Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingLookTo Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingLookTo Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingLookTo Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingLookTo EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingLookTo EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingLookTo LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingLookTo LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingLookTo OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingLookTo OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingLookTo OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingLookTo OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingLookTo OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingLookTo OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingLookTo OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingLookTo OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingLookTo OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingLookTo OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingLookTo OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingLookTo IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingLookUpdate
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingLookUpdate (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.LookUpdate(go, args);
    }

    public OutgoingLookUpdate LookTarget(Transform lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingLookUpdate LookTarget(Vector3 lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingLookUpdate Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingLookUpdate Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingLookUpdate Time(double time)
    {
        args.Add("time", time);
        return this;
    }

} 

public class OutgoingMoveAdd
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingMoveAdd (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.MoveAdd(go, args);
    }

    public OutgoingMoveAdd Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingMoveAdd Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingMoveAdd X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveAdd X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveAdd Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveAdd Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveAdd Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveAdd Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveAdd OrientToPath(bool orientToPath)
    {
        args.Add("orienttopath", orientToPath);
        return this;
    }
    public OutgoingMoveAdd LookTarget(Transform lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveAdd LookTarget(Vector3 lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveAdd LookTime(float lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveAdd LookTime(double lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveAdd Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingMoveAdd Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingMoveAdd Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingMoveAdd Space(Space space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingMoveAdd Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingMoveAdd Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingMoveAdd Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingMoveAdd Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingMoveAdd EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingMoveAdd EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingMoveAdd LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingMoveAdd LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingMoveAdd OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingMoveAdd OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingMoveAdd OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingMoveAdd OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingMoveAdd OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingMoveAdd OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingMoveAdd OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingMoveAdd OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingMoveAdd OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingMoveAdd OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingMoveAdd OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingMoveAdd IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingMoveBy
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingMoveBy (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.MoveBy(go, args);
    }

    public OutgoingMoveBy Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingMoveBy Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingMoveBy X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveBy X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveBy Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveBy Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveBy Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveBy Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveBy OrientToPath(bool orientToPath)
    {
        args.Add("orienttopath", orientToPath);
        return this;
    }
    public OutgoingMoveBy LookTarget(Transform lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveBy LookTarget(Vector3 lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveBy LookTime(float lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveBy LookTime(double lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveBy Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingMoveBy Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingMoveBy Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingMoveBy Space(Space space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingMoveBy Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingMoveBy Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingMoveBy Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingMoveBy Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingMoveBy EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingMoveBy EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingMoveBy LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingMoveBy LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingMoveBy OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingMoveBy OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingMoveBy OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingMoveBy OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingMoveBy OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingMoveBy OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingMoveBy OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingMoveBy OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingMoveBy OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingMoveBy OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingMoveBy OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingMoveBy IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingMoveFrom
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingMoveFrom (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.MoveFrom(go, args);
    }

    public OutgoingMoveFrom Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingMoveFrom Position(Vector3 position)
    {
        args.Add("position", position);
        return this;
    }
    public OutgoingMoveFrom Position(Transform position)
    {
        args.Add("position", position);
        return this;
    }
    public OutgoingMoveFrom Path(Vector3[] path)
    {
        args.Add("path", path);
        return this;
    }
    public OutgoingMoveFrom Path(Transform[] path)
    {
        args.Add("path", path);
        return this;
    }
    public OutgoingMoveFrom MoveToPath(bool moveToPath)
    {
        args.Add("movetopath", moveToPath);
        return this;
    }
    public OutgoingMoveFrom X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveFrom X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveFrom Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveFrom Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveFrom Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveFrom Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveFrom OrientToPath(bool orientToPath)
    {
        args.Add("orienttopath", orientToPath);
        return this;
    }
    public OutgoingMoveFrom LookTarget(Transform lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveFrom LookTarget(Vector3 lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveFrom LookTime(float lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveFrom LookTime(double lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveFrom LookAhead(float lookAhead)
    {
        args.Add("lookahead", lookAhead);
        return this;
    }
    public OutgoingMoveFrom LookAhead(double lookAhead)
    {
        args.Add("lookahead", lookAhead);
        return this;
    }
    public OutgoingMoveFrom Islocal(bool islocal)
    {
        args.Add("islocal", islocal);
        return this;
    }
    public OutgoingMoveFrom Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingMoveFrom Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingMoveFrom Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingMoveFrom Space(Space space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingMoveFrom Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingMoveFrom Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingMoveFrom Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingMoveFrom Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingMoveFrom EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingMoveFrom EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingMoveFrom LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingMoveFrom LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingMoveFrom OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingMoveFrom OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingMoveFrom OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingMoveFrom OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingMoveFrom OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingMoveFrom OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingMoveFrom OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingMoveFrom OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingMoveFrom OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingMoveFrom OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingMoveFrom OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingMoveFrom IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingMoveTo
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingMoveTo (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.MoveTo(go, args);
    }

    public OutgoingMoveTo Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingMoveTo Position(Vector3 position)
    {
        args.Add("position", position);
        return this;
    }
    public OutgoingMoveTo Position(Transform position)
    {
        args.Add("position", position);
        return this;
    }
    public OutgoingMoveTo Path(Vector3[] path)
    {
        args.Add("path", path);
        return this;
    }
    public OutgoingMoveTo Path(Transform[] path)
    {
        args.Add("path", path);
        return this;
    }
    public OutgoingMoveTo MoveToPath(bool moveToPath)
    {
        args.Add("movetopath", moveToPath);
        return this;
    }
    public OutgoingMoveTo X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveTo X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveTo Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveTo Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveTo Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveTo Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveTo OrientToPath(bool orientToPath)
    {
        args.Add("orienttopath", orientToPath);
        return this;
    }
    public OutgoingMoveTo LookTarget(Transform lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveTo LookTarget(Vector3 lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveTo LookTime(float lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveTo LookTime(double lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveTo LookAhead(float lookAhead)
    {
        args.Add("lookahead", lookAhead);
        return this;
    }
    public OutgoingMoveTo LookAhead(double lookAhead)
    {
        args.Add("lookahead", lookAhead);
        return this;
    }
    public OutgoingMoveTo Islocal(bool islocal)
    {
        args.Add("islocal", islocal);
        return this;
    }
    public OutgoingMoveTo Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingMoveTo Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingMoveTo Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingMoveTo Space(Space space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingMoveTo Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingMoveTo Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingMoveTo Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingMoveTo Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingMoveTo EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingMoveTo EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingMoveTo LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingMoveTo LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingMoveTo OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingMoveTo OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingMoveTo OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingMoveTo OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingMoveTo OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingMoveTo OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingMoveTo OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingMoveTo OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingMoveTo OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingMoveTo OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingMoveTo OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingMoveTo IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingMoveUpdate
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingMoveUpdate (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.MoveUpdate(go, args);
    }

    public OutgoingMoveUpdate Position(Vector3 position)
    {
        args.Add("position", position);
        return this;
    }
    public OutgoingMoveUpdate Position(Transform position)
    {
        args.Add("position", position);
        return this;
    }
    public OutgoingMoveUpdate X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveUpdate X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingMoveUpdate Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveUpdate Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingMoveUpdate Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveUpdate Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingMoveUpdate OrientToPath(bool orientToPath)
    {
        args.Add("orienttopath", orientToPath);
        return this;
    }
    public OutgoingMoveUpdate LookTarget(Transform lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveUpdate LookTarget(Vector3 lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingMoveUpdate LookTime(float lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveUpdate LookTime(double lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingMoveUpdate LookAhead(float lookAhead)
    {
        args.Add("lookahead", lookAhead);
        return this;
    }
    public OutgoingMoveUpdate LookAhead(double lookAhead)
    {
        args.Add("lookahead", lookAhead);
        return this;
    }
    public OutgoingMoveUpdate Islocal(bool islocal)
    {
        args.Add("islocal", islocal);
        return this;
    }
    public OutgoingMoveUpdate Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingMoveUpdate Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingMoveUpdate Time(double time)
    {
        args.Add("time", time);
        return this;
    }

} 

public class OutgoingPunchPosition
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingPunchPosition (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.PunchPosition(go, args);
    }

    public OutgoingPunchPosition Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingPunchPosition Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingPunchPosition X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingPunchPosition X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingPunchPosition Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingPunchPosition Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingPunchPosition Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingPunchPosition Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingPunchPosition LookTarget(Transform lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingPunchPosition LookTarget(Vector3 lookTarget)
    {
        args.Add("looktarget", lookTarget);
        return this;
    }
    public OutgoingPunchPosition LookTime(float lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingPunchPosition LookTime(double lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingPunchPosition Islocal(bool islocal)
    {
        args.Add("islocal", islocal);
        return this;
    }
    public OutgoingPunchPosition Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingPunchPosition Space(Space space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingPunchPosition Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingPunchPosition Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingPunchPosition Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingPunchPosition Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingPunchPosition EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingPunchPosition EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingPunchPosition LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingPunchPosition LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingPunchPosition OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingPunchPosition OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingPunchPosition OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingPunchPosition OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingPunchPosition OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingPunchPosition OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingPunchPosition OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingPunchPosition OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingPunchPosition OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingPunchPosition OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingPunchPosition OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingPunchPosition IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingPunchRotation
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingPunchRotation (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.PunchRotation(go, args);
    }

    public OutgoingPunchRotation Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingPunchRotation Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingPunchRotation X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingPunchRotation X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingPunchRotation Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingPunchRotation Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingPunchRotation Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingPunchRotation Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingPunchRotation Space(Space space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingPunchRotation Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingPunchRotation Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingPunchRotation Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingPunchRotation Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingPunchRotation EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingPunchRotation EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingPunchRotation LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingPunchRotation LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingPunchRotation OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingPunchRotation OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingPunchRotation OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingPunchRotation OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingPunchRotation OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingPunchRotation OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingPunchRotation OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingPunchRotation OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingPunchRotation OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingPunchRotation OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingPunchRotation OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingPunchRotation IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingPunchScale
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingPunchScale (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.PunchScale(go, args);
    }

    public OutgoingPunchScale Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingPunchScale Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingPunchScale X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingPunchScale X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingPunchScale Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingPunchScale Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingPunchScale Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingPunchScale Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingPunchScale Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingPunchScale Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingPunchScale Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingPunchScale Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingPunchScale EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingPunchScale EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingPunchScale LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingPunchScale LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingPunchScale OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingPunchScale OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingPunchScale OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingPunchScale OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingPunchScale OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingPunchScale OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingPunchScale OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingPunchScale OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingPunchScale OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingPunchScale OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingPunchScale OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingPunchScale IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingRotateAdd
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingRotateAdd (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.RotateAdd(go, args);
    }

    public OutgoingRotateAdd Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingRotateAdd Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingRotateAdd X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateAdd X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateAdd Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateAdd Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateAdd Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateAdd Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateAdd Space(Space space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingRotateAdd Space(string space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingRotateAdd Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingRotateAdd Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingRotateAdd Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingRotateAdd Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingRotateAdd EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingRotateAdd EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingRotateAdd LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingRotateAdd LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingRotateAdd OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingRotateAdd OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingRotateAdd OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingRotateAdd OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingRotateAdd OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingRotateAdd OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingRotateAdd OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingRotateAdd OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingRotateAdd OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingRotateAdd OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingRotateAdd OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingRotateAdd IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingRotateBy
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingRotateBy (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.RotateBy(go, args);
    }

    public OutgoingRotateBy Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingRotateBy Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingRotateBy X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateBy X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateBy Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateBy Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateBy Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateBy Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateBy Space(Space space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingRotateBy Space(string space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingRotateBy Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingRotateBy Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingRotateBy Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingRotateBy Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingRotateBy Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingRotateBy Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingRotateBy EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingRotateBy EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingRotateBy LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingRotateBy LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingRotateBy OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingRotateBy OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingRotateBy OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingRotateBy OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingRotateBy OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingRotateBy OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingRotateBy OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingRotateBy OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingRotateBy OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingRotateBy OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingRotateBy OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingRotateBy IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingRotateFrom
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingRotateFrom (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.RotateFrom(go, args);
    }

    public OutgoingRotateFrom Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingRotateFrom Rotation(Vector3 rotation)
    {
        args.Add("rotation", rotation);
        return this;
    }
    public OutgoingRotateFrom Rotation(Transform rotation)
    {
        args.Add("rotation", rotation);
        return this;
    }
    public OutgoingRotateFrom X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateFrom X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateFrom Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateFrom Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateFrom Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateFrom Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateFrom IsLocal(bool isLocal)
    {
        args.Add("islocal", isLocal);
        return this;
    }
    public OutgoingRotateFrom Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingRotateFrom Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingRotateFrom Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingRotateFrom Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingRotateFrom Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingRotateFrom Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingRotateFrom EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingRotateFrom EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingRotateFrom LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingRotateFrom LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingRotateFrom OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingRotateFrom OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingRotateFrom OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingRotateFrom OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingRotateFrom OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingRotateFrom OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingRotateFrom OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingRotateFrom OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingRotateFrom OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingRotateFrom OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingRotateFrom OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingRotateFrom IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingRotateTo
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingRotateTo (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.RotateTo(go, args);
    }

    public OutgoingRotateTo Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingRotateTo Rotation(Vector3 rotation)
    {
        args.Add("rotation", rotation);
        return this;
    }
    public OutgoingRotateTo Rotation(Transform rotation)
    {
        args.Add("rotation", rotation);
        return this;
    }
    public OutgoingRotateTo X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateTo X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateTo Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateTo Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateTo Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateTo Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateTo IsLocal(bool isLocal)
    {
        args.Add("islocal", isLocal);
        return this;
    }
    public OutgoingRotateTo Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingRotateTo Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingRotateTo Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingRotateTo Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingRotateTo Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingRotateTo Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingRotateTo EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingRotateTo EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingRotateTo LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingRotateTo LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingRotateTo OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingRotateTo OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingRotateTo OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingRotateTo OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingRotateTo OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingRotateTo OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingRotateTo OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingRotateTo OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingRotateTo OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingRotateTo OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingRotateTo OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingRotateTo IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingRotateUpdate
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingRotateUpdate (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.RotateUpdate(go, args);
    }

    public OutgoingRotateUpdate Rotation(Vector3 rotation)
    {
        args.Add("rotation", rotation);
        return this;
    }
    public OutgoingRotateUpdate Rotation(Transform rotation)
    {
        args.Add("rotation", rotation);
        return this;
    }
    public OutgoingRotateUpdate X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateUpdate X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingRotateUpdate Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateUpdate Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingRotateUpdate Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateUpdate Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingRotateUpdate IsLocal(bool isLocal)
    {
        args.Add("islocal", isLocal);
        return this;
    }
    public OutgoingRotateUpdate Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingRotateUpdate Time(double time)
    {
        args.Add("time", time);
        return this;
    }

} 

public class OutgoingScaleAdd
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingScaleAdd (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ScaleAdd(go, args);
    }

    public OutgoingScaleAdd Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingScaleAdd Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingScaleAdd X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleAdd X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleAdd Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleAdd Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleAdd Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingScaleAdd Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingScaleAdd Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingScaleAdd Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingScaleAdd Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingScaleAdd Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingScaleAdd Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingScaleAdd Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingScaleAdd EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingScaleAdd EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingScaleAdd LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingScaleAdd LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingScaleAdd OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingScaleAdd OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingScaleAdd OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingScaleAdd OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingScaleAdd OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingScaleAdd OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingScaleAdd OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingScaleAdd OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingScaleAdd OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingScaleAdd OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingScaleAdd OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingScaleAdd IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingScaleBy
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingScaleBy (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ScaleBy(go, args);
    }

    public OutgoingScaleBy Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingScaleBy Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingScaleBy X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleBy X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleBy Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleBy Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleBy Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingScaleBy Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingScaleBy Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingScaleBy Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingScaleBy Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingScaleBy Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingScaleBy Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingScaleBy Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingScaleBy EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingScaleBy EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingScaleBy LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingScaleBy LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingScaleBy OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingScaleBy OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingScaleBy OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingScaleBy OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingScaleBy OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingScaleBy OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingScaleBy OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingScaleBy OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingScaleBy OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingScaleBy OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingScaleBy OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingScaleBy IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingScaleFrom
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingScaleFrom (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ScaleFrom(go, args);
    }

    public OutgoingScaleFrom Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingScaleFrom Scale(Vector3 scale)
    {
        args.Add("scale", scale);
        return this;
    }
    public OutgoingScaleFrom Scale(Transform scale)
    {
        args.Add("scale", scale);
        return this;
    }
    public OutgoingScaleFrom X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleFrom X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleFrom Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleFrom Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleFrom Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingScaleFrom Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingScaleFrom Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingScaleFrom Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingScaleFrom Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingScaleFrom Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingScaleFrom Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingScaleFrom Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingScaleFrom EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingScaleFrom EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingScaleFrom LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingScaleFrom LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingScaleFrom OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingScaleFrom OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingScaleFrom OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingScaleFrom OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingScaleFrom OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingScaleFrom OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingScaleFrom OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingScaleFrom OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingScaleFrom OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingScaleFrom OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingScaleFrom OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingScaleFrom IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingScaleTo
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingScaleTo (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ScaleTo(go, args);
    }

    public OutgoingScaleTo Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingScaleTo Scale(Vector3 scale)
    {
        args.Add("scale", scale);
        return this;
    }
    public OutgoingScaleTo Scale(Transform scale)
    {
        args.Add("scale", scale);
        return this;
    }
    public OutgoingScaleTo X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleTo X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleTo Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleTo Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleTo Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingScaleTo Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingScaleTo Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingScaleTo Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingScaleTo Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingScaleTo Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingScaleTo Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingScaleTo Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingScaleTo EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingScaleTo EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingScaleTo LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingScaleTo LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingScaleTo OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingScaleTo OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingScaleTo OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingScaleTo OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingScaleTo OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingScaleTo OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingScaleTo OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingScaleTo OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingScaleTo OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingScaleTo OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingScaleTo OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingScaleTo IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingScaleUpdate
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingScaleUpdate (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ScaleUpdate(go, args);
    }

    public OutgoingScaleUpdate Scale(Vector3 scale)
    {
        args.Add("scale", scale);
        return this;
    }
    public OutgoingScaleUpdate Scale(Transform scale)
    {
        args.Add("scale", scale);
        return this;
    }
    public OutgoingScaleUpdate X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleUpdate X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingScaleUpdate Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleUpdate Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingScaleUpdate Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingScaleUpdate Z(double z)
    {
        args.Add("z", z);
        return this;
    }

} 

public class OutgoingShakePosition
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingShakePosition (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ShakePosition(go, args);
    }

    public OutgoingShakePosition Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingShakePosition Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingShakePosition X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingShakePosition X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingShakePosition Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingShakePosition Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingShakePosition Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingShakePosition Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingShakePosition IsLocal(bool isLocal)
    {
        args.Add("islocal", isLocal);
        return this;
    }
    public OutgoingShakePosition OrientToPath(bool orientToPath)
    {
        args.Add("orienttopath", orientToPath);
        return this;
    }
    public OutgoingShakePosition LookTime(float lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingShakePosition LookTime(double lookTime)
    {
        args.Add("looktime", lookTime);
        return this;
    }
    public OutgoingShakePosition Axis(string axis)
    {
        args.Add("axis", axis);
        return this;
    }
    public OutgoingShakePosition Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingShakePosition Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingShakePosition Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingShakePosition Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingShakePosition LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingShakePosition LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingShakePosition OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingShakePosition OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingShakePosition OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingShakePosition OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingShakePosition OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingShakePosition OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingShakePosition OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingShakePosition OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingShakePosition OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingShakePosition OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingShakePosition OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingShakePosition IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingShakeRotation
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingShakeRotation (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ShakeRotation(go, args);
    }

    public OutgoingShakeRotation Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingShakeRotation Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingShakeRotation X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingShakeRotation X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingShakeRotation Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingShakeRotation Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingShakeRotation Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingShakeRotation Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingShakeRotation Space(Space space)
    {
        args.Add("space", space);
        return this;
    }
    public OutgoingShakeRotation Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingShakeRotation Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingShakeRotation Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingShakeRotation Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingShakeRotation LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingShakeRotation LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingShakeRotation OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingShakeRotation OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingShakeRotation OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingShakeRotation OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingShakeRotation OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingShakeRotation OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingShakeRotation OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingShakeRotation OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingShakeRotation OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingShakeRotation OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingShakeRotation OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingShakeRotation IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingShakeScale
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingShakeScale (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ShakeScale(go, args);
    }

    public OutgoingShakeScale Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingShakeScale Amount(Vector3 amount)
    {
        args.Add("amount", amount);
        return this;
    }
    public OutgoingShakeScale X(float x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingShakeScale X(double x)
    {
        args.Add("x", x);
        return this;
    }
    public OutgoingShakeScale Y(float y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingShakeScale Y(double y)
    {
        args.Add("y", y);
        return this;
    }
    public OutgoingShakeScale Z(float z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingShakeScale Z(double z)
    {
        args.Add("z", z);
        return this;
    }
    public OutgoingShakeScale Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingShakeScale Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingShakeScale Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingShakeScale Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingShakeScale LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingShakeScale LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingShakeScale OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingShakeScale OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingShakeScale OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingShakeScale OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingShakeScale OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingShakeScale OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingShakeScale OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingShakeScale OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingShakeScale OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingShakeScale OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingShakeScale OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingShakeScale IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingStab
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingStab (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.Stab(go, args);
    }

    public OutgoingStab AudioClip(AudioClip audioClip)
    {
        args.Add("audioclip", audioClip);
        return this;
    }
    public OutgoingStab AudioSource(AudioSource audioSource)
    {
        args.Add("audiosource", audioSource);
        return this;
    }
    public OutgoingStab Volume(float volume)
    {
        args.Add("volume", volume);
        return this;
    }
    public OutgoingStab Volume(double volume)
    {
        args.Add("volume", volume);
        return this;
    }
    public OutgoingStab Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingStab Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingStab OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingStab OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingStab OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingStab OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingStab OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingStab OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingStab OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingStab OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingStab OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingStab OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingStab OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingStab IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 

public class OutgoingValueTo
{

    private Hashtable args = new Hashtable();
    private GameObject go;

    public OutgoingValueTo (GameObject go)
    {
        this.go = go;
    }

    public void Start ()
    {
        iTween.ValueTo(go, args);
    }

    public OutgoingValueTo Name(string name)
    {
        args.Add("name", name);
        return this;
    }
    public OutgoingValueTo From(float from)
    {
        args.Add("from", from);
        return this;
    }
    public OutgoingValueTo From(double from)
    {
        args.Add("from", from);
        return this;
    }
    public OutgoingValueTo From(Vector2 from)
    {
        args.Add("from", from);
        return this;
    }
    public OutgoingValueTo From(Vector3 from)
    {
        args.Add("from", from);
        return this;
    }
    public OutgoingValueTo From(Color from)
    {
        args.Add("from", from);
        return this;
    }
    public OutgoingValueTo From(Rect from)
    {
        args.Add("from", from);
        return this;
    }
    public OutgoingValueTo To(float to)
    {
        args.Add("to", to);
        return this;
    }
    public OutgoingValueTo To(double to)
    {
        args.Add("to", to);
        return this;
    }
    public OutgoingValueTo To(Vector2 to)
    {
        args.Add("to", to);
        return this;
    }
    public OutgoingValueTo To(Vector3 to)
    {
        args.Add("to", to);
        return this;
    }
    public OutgoingValueTo To(Color to)
    {
        args.Add("to", to);
        return this;
    }
    public OutgoingValueTo To(Rect to)
    {
        args.Add("to", to);
        return this;
    }
    public OutgoingValueTo Time(float time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingValueTo Time(double time)
    {
        args.Add("time", time);
        return this;
    }
    public OutgoingValueTo Speed(float speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingValueTo Speed(double speed)
    {
        args.Add("speed", speed);
        return this;
    }
    public OutgoingValueTo Delay(float delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingValueTo Delay(double delay)
    {
        args.Add("delay", delay);
        return this;
    }
    public OutgoingValueTo EaseType(iTween.EaseType easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingValueTo EaseType(string easeType)
    {
        args.Add("easetype", easeType);
        return this;
    }
    public OutgoingValueTo LoopType(iTween.LoopType loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingValueTo LoopType(string loopType)
    {
        args.Add("looptype", loopType);
        return this;
    }
    public OutgoingValueTo OnStart(string onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingValueTo OnStart(System.Action onStart)
    {
        args.Add("onstart", onStart);
        return this;
    }
    public OutgoingValueTo OnStartTarget(GameObject onStartTarget)
    {
        args.Add("onstarttarget", onStartTarget);
        return this;
    }
    public OutgoingValueTo OnStartParams(Object onStartParams)
    {
        args.Add("onstartparams", onStartParams);
        return this;
    }
    public OutgoingValueTo OnUpdate(string onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingValueTo OnUpdate(System.Action onUpdate)
    {
        args.Add("onupdate", onUpdate);
        return this;
    }
    public OutgoingValueTo OnUpdateTarget(GameObject onUpdateTarget)
    {
        args.Add("onupdatetarget", onUpdateTarget);
        return this;
    }
    public OutgoingValueTo OnUpdateParams(Object onUpdateParams)
    {
        args.Add("onupdateparams", onUpdateParams);
        return this;
    }
    public OutgoingValueTo OnComplete(string onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingValueTo OnComplete(System.Action onComplete)
    {
        args.Add("oncomplete", onComplete);
        return this;
    }
    public OutgoingValueTo OnCompleteTarget(GameObject onCompleteTarget)
    {
        args.Add("oncompletetarget", onCompleteTarget);
        return this;
    }
    public OutgoingValueTo IgnoreTimesSale(bool ignoreTimesSale)
    {
        args.Add("ignoretimessale", ignoreTimesSale);
        return this;
    }

} 
