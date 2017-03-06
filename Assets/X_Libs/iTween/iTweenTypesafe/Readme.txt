To access iTween Typesafe from JS and Boo you have to place iTween.cs and iTweenExtension.cs in [Path to project]\Assets\Plugins folder.

All iTween methods in GameObject starts with "i":
iAudioFrom
iAudioTo
iAudioUpdate
iColorFrom
iColorTo
iColorUpdate
iFadeFrom
iFadeTo
iFadeUpdate
iLookFrom
iLookTo
iLookUpdate
iMoveAdd
iMoveBy
iMoveFrom
iMoveTo
iMoveUpdate
iPunchPosition
iPunchRotation
iPunchScale
iRotateAdd
iRotateBy
iRotateFrom
iRotateTo
iRotateUpdate
iScaleAdd
iScaleBy
iScaleFrom
iScaleTo
iScaleUpdate
iShakePosition
iShakeRotation
iShakeScale
iStab
iValueTo

iInit
iStop
iResume
iPause
iCount

All of properties are accessible as methods,
example:
Action: AudioFrom 
Property Name: delay
Extension: gameObject.iAudioFrom().Delay(1.0f)
All 'actions' and 'properties' can be found at http://itween.pixelplacement.com/documentation.php

To finalize iTween action its required to call Start(),
example:
	gameObject.iAudioFrom().Delay(1.0f).Start()

There are iTween methods not connected with GameObject:
iTweenExtension.iCameraFadeFrom
iTweenExtension.iCameraFadeTo

Rest of iTween methods are typesafe,
example:
CameraFadeAdd, CameraFadeDepth, StopByName, Vector2Update...

