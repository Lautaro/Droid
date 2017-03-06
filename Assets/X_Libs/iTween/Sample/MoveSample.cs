using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{	
		void Start ()
		{
				
				gameObject.iRotateFrom ().Y (90).Time (1).Delay (0).EaseType (iTween.EaseType.easeInOutExpo).Start ();
				//	gameObject.iRotateFrom ().Y (-90).Time (1).Delay (3).EaseType (iTween.EaseType.easeInOutExpo).Start ();
				gameObject.iMoveFrom ().Y (3.5).Time (1).Delay (0.3).EaseType (iTween.EaseType.easeInOutExpo).Start ();
				gameObject.iColorTo ().R (3).G (0.5).B (1.2).Time (1.5).Delay (1.5).LoopType (iTween.LoopType.pingPong).Start ();
				gameObject.iMoveTo ().X (3.5).Time (1).Delay (1).EaseType (iTween.EaseType.easeInOutExpo).Start ();
				gameObject.iMoveTo ().Y (3.5).Time (1).Delay (1.5).EaseType (iTween.EaseType.easeInOutExpo).Start ();
				gameObject.iMoveTo ().X (0).Time (1).Delay (2).EaseType (iTween.EaseType.easeInOutExpo).Start ();
				gameObject.iMoveTo ().Y (0).Time (1).Delay (2.5).EaseType (iTween.EaseType.easeInOutExpo).Start ();
//				gameObject.iPunchPosition ().Y (3).Time (.8).Delay (1.5).Start ();
				//iTween.MoveBy (gameObject, iTween.Hash ("x", 2, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));















//	iTween.rotateFrom(go,{"y":90, "time":1.5, "transition":"easeInExpo"});
//	iTween.moveFrom(go,{"y":3.5, "time":1.5, "transition":"easeInExpo"});
//	iTween.colorTo(go,{"r":3, "g":.5, "b":1.2, "time":.3, "delay":1.5});
//	iTween.shake(cam,{"y":.3, "time":.8, "delay":1.5});
		}
}

