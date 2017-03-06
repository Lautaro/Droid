using UnityEngine;
//using System.Collections;

public class DroidWheeledMovement : MonoBehaviour
{
	#region Properties

   public bool WasMoving = false;

    public AudioClip DroidMovement;
    public AudioClip DroidMovementCoolDown;
    public AudioSource movementAudio;

	/// <summary>
	/// The target rotation angle.
	/// </summary>
	public int targetAngle;

	/// <summary>
	/// Position the autopilot wants to reach. 
	/// </summary>
	Vector2 autoPilotTarget;

	/// <summary>
	/// If player moves droid with keys
	/// </summary>
	public	bool manualAcceleration;

	/// <summary>
	/// Is droid currently rotating?
	/// </summary>
	bool rotating;

	/// <summary>
	/// Is autopilot activated?
	/// </summary>
	public	bool autoPilotActivated = false;

    

	public int angle;
	public bool accelerating; 

	public int Angle {
		get {
			return (int)transform.rotation.eulerAngles.z;
		}
	}

	/// <summary>
	/// Returns the angle to face the autopilot target
	/// </summary>
	/// <value>The angle to target.</value>
	int AngleToAutoPilotTarget {
		get {
			if (autoPilotTarget != null) {
				return (int)Tools.RotateZTowards (transform, autoPilotTarget).z;
			} else {
				return -1;
			}		
		}
	}

	/// <summary>
	/// Gets the angle difference between current angle and target angle.
	/// </summary>
	/// <value>The angle difference.</value>
	int AngleDifference {
		get {
			return  Mathf.Abs (Angle - targetAngle);
		}
	}

	public float Velocity {
		get {
			return rigidbody2D.velocity.magnitude;
		}
	}

	public string VelocityFormated {
		get {
			return Velocity.ToString ("0");
		}
	}

	public float distanceToTarget {
		get {
			return	Vector2.Distance (transform.position, autoPilotTarget);
		}
	}

	public float acceleration = 10f;
	#endregion

	// Use this for initialization
	void Start ()
	{
        movementAudio = gameObject.AddComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		//DEBUG STATS
		angle = Angle;
		//END


		manualAcceleration = false;

		if (Input.anyKey) {
			CheckForKeys ();
		}

	
		if (autoPilotActivated) {
		
			AutoPilotCheck ();
		} else {
			ManualPilot ();
		}


		Accelerate ();
        
        if (manualAcceleration && !WasMoving)
        {
            movementAudio.clip = DroidMovement;
            movementAudio.Play();
            
            movementAudio.volume = 0.6f;
            movementAudio.loop = true;
            WasMoving = true;

        }

        if (!manualAcceleration && WasMoving)
        {
            movementAudio.clip = DroidMovementCoolDown;
            movementAudio.Play();
            movementAudio.volume = 0.6f;
            movementAudio.loop = false;
            WasMoving = false;
            
        }

	}

	void CheckForKeys ()
	{
		if (Input.GetKey (KeyCode.W)) {
			manualAcceleration = true;
			autoPilotActivated = false;


			if (Input.GetKey (KeyCode.A)) {
				
				//UP LEFT
				targetAngle = 45;
				
			} else { 
				//UP
				targetAngle = (0);
			}			
		} else
			
		if (Input.GetKey (KeyCode.A)) {
			//LEFT
			manualAcceleration = true;
			autoPilotActivated = false;
			targetAngle = (90);
		} 

		if (Input.GetKey (KeyCode.S)) {
			manualAcceleration = true;
			autoPilotActivated = false;
			//DOWN LEFT
			targetAngle = (180);

			if (Input.GetKey (KeyCode.A)) {
				//DOWN LEFT
				targetAngle = (135);
			} else 
			if (Input.GetKey (KeyCode.D)) {
				//DOWN RIGHT
				targetAngle = (225);
			}			
		} else
			
		if (Input.GetKey (KeyCode.D)) {
			//RIGHT
			manualAcceleration = true;
			autoPilotActivated = false;
			targetAngle = (270);

		

			if (Input.GetKey (KeyCode.W)) {
				//UP LEFT
				targetAngle = (315);
			}
		} 
		RotateToTarget ();
	}

	void Accelerate ()
	{
		accelerating = false;
		if (manualAcceleration || autoPilotActivated) {
			if (AngleDifference < 45) {

				//DONT ACCELERATE IF ANGLE DIFFERENCE IS TO HIGH
				rigidbody2D.AddForce (transform.up * acceleration);
				accelerating = true;
            
			} 
		}


      
	}

	void Decelerate ()
	{
		
	}

	public void SetAutoPilot (Vector2 target)
	{

		autoPilotActivated = true;
		autoPilotTarget = target;
	
		targetAngle = (int)Tools.RotateZTowards (gameObject.transform, target).z;
		//print ("AUTOPILOT ON. Target angle: " + targetAngle);
		RotateToTarget ();
	}


/// <summary>
/// Rotates to the set target angle.
/// </summary>
	void RotateToTarget ()
	{

		if (Angle != targetAngle) {		
			//print ("Current angle: " + Angle + "  newTargetAngle: " + targetAngle);
			rotating = true;
		
			gameObject.iRotateTo ().
			Rotation (new Vector3 (0, 0, targetAngle)).
				Speed (acceleration).
				EaseType (iTween.EaseType.easeOutSine).
				OnComplete ("RotationComplete").
				Start ();
		} else {
			//print ("I wont rotate");
		}
	}

	void AutoPilotCheck ()
	{

		// CHECK IF REALIGNMENT IS NESCESSARY
		if (AngleToAutoPilotTarget != angle && !rotating) {
			//print ("realigning");
			SetAutoPilot (autoPilotTarget);
		}



		if (autoPilotTarget != null) {

			if (distanceToTarget < 8) {
				autoPilotActivated = false;
			}
		}
	}

	void ManualPilot ()
	{

	}

	void RotationComplete ()
	{
		//print ("Im done rotating: " + Angle);
		rotating = false;

	}
}
