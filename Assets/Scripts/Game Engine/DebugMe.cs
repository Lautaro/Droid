using UnityEngine;
using System.Collections;

public class DebugMe : MonoBehaviour
{

		public	bool doPrint = true;
		public bool doMouseEvents = false;
		public bool doStartUp = false;
		public bool doCustomMessages = true;

		Color renderColor; 

		void Awake ()
		{
				if (GetComponent<Renderer>()) {
						renderColor = GetComponent<Renderer>().material.color;
				}
		}
	
		// Use this for initialization
		void Start ()
		{
				if (doStartUp) {
						PrintToLog ("Start: " + name);
				}
		}
	
		void OnMouseDown ()
		{
				if (doMouseEvents)
						PrintToLog ("CLICK down: " + name);
		}
	
		void OnMouseUp ()
		{
				if (doMouseEvents)
						PrintToLog ("Mouse up: " + name);
		}
	
		void OnMouseEnter ()
		{				
				if (doMouseEvents) {
						PrintToLog ("Mouse Enter: " + name);
						if (GetComponent<Renderer>()) {
								var color = new Color (1f, 0.3f, 0.3f, 1f);
								GetComponent<Renderer>().material.color = color;
						}
				}
				
		}
		void OnMouseExit ()
		{
				if (doMouseEvents) {
						PrintToLog ("Mouse Exit: " + name);
						if (GetComponent<Renderer>()) {
								GetComponent<Renderer>().material.color = renderColor;
						}
				}
		}

		void OnHover (bool isOver)
		{
				if (doMouseEvents) {
						if (isOver) {
								if (GetComponent<Renderer>()) {
										PrintToLog ("NGUI Mouse HOVER: " + name);
										var color = new Color (0.3f, 0.3f, 1f, 1f);
										GetComponent<Renderer>().material.color = color;
								}
						} else {
								if (GetComponent<Renderer>()) {
										PrintToLog ("NGUI Mouse OUT: " + name);
										GetComponent<Renderer>().material.color = renderColor;
								}
						}
				}
		}

		void OnPress (bool isDown)
		{
				if (doMouseEvents) {
						if (isDown) {
								PrintToLog ("NGUI Click DOWN: " + name);
						
						} else {
								PrintToLog ("NGUI Click Up: " + name);						
						}
				}
		}

		void PrintToLog (string message)
		{
				if (doPrint) {
						print (message);
				}
		}
		public void DebugThis (string message)
		{
				if (doCustomMessages) {
						print (message);
				}
		}
}
