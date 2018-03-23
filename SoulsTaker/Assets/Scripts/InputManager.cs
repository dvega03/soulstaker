using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public static float MainHorizontal()
	{
		float h = 0.0f;
		h-=Input.GetAxis("Horizontal");
		h+=Input.GetAxis("Horizontal");
		return Mathf.Clamp (h, -1.0f, 1.0f);
	}
	public static float MainVertical(){
		float v = 0.0f;
		v += Input.GetAxis ("Vertical");
		return Mathf.Clamp (v, -1.0f, 1.0f);
	}
	public static Vector3 MainControl(){
		return new Vector3 (MainHorizontal(),MainVertical(),0);
	}
	public static float LookHorizontal()                       // (Mando: Joystick Derecho ; Teclado: Flecha izq [<0], Flecha drch [>0])
	{
		float r = 0.0f;
		r += Input.GetAxis("LookHorizontal");
		return Mathf.Clamp(r, -1.0f, 1.0f);
	}
	public static float LookVertical(){
		float t = 0.0f;
		t += Input.GetAxis ("LookVertical");
		return Mathf.Clamp (t, -1.0f, 1.0f);
	}

	public static Vector3 LookJoystick(){
		return new Vector3(LookHorizontal(), 0, LookVertical());
	}
	//--buttons
	public static bool Abutton(){
		return Input.GetButton ("A_Button");	
	}

	public static bool Bbutton(){
		return Input.GetButton ("B_Button");	
	}
	public static bool Ybutton(){
		return Input.GetButton ("Y_Button");	
	}

	public static bool Xbutton(){
		return Input.GetButton ("X_Button");	
	}
	public static bool LBButton()                           // (Teclado: U)
	{
		return Input.GetButtonDown("LB_Button");
	}
	public static bool RBButton()                           // (Teclado: O)
	{
		return Input.GetButtonDown("RB_Button");
	}
}