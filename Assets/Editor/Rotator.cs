using UnityEditor;
using UnityEngine;

public class Rotator : EditorWindow
{
    public int index1 = 0;
    public int index2 = 0;
	public string[] rotation = new string[] {"15", "30", "45", "60", "75", "90", "-15", "-30", "-45", "-60", "-75", "-90"};
	public string[] direction = new string[] {"X", "Y", "Z"};


    [MenuItem("Window/EZRotator")]
	public static void ShowWindow()
	{
		GetWindow<Rotator>("EZRotator");

	}
	public void OnGUI()
	{
		
		index1 = EditorGUILayout.Popup(index1, rotation);
		index2 = EditorGUILayout.Popup(index2, direction);
		

		if (GUILayout.Button("Rotate"))
		{
			//rotate the object by amounts set by dropdown menus
			Rotate();
		}
	}

	void Rotate()
	{
		GameObject obj = Selection.activeGameObject;
		float rot = 0;
		float rotNew;
		float oldX;
		float oldY;
		float oldZ;

		if (obj != null)
		{
			oldX = obj.transform.rotation.x;
			oldY = obj.transform.rotation.y;
			oldZ = obj.transform.rotation.z;


			switch (index1)
        	{
	            case 0:
    	            rot = 15;
    	            
        	        break;
            	case 1:
                	rot = 30;
                	break;
            	case 2:
	                rot = 45;
                	break;
            	case 3:
	                rot = 60;
                	break;
            	case 4:
	                rot = 75;
                	break;
            	case 5:
	                rot = 90;
                	break;
            	case 6:
	                rot = -15;
                	break;
            	case 7:
	                rot = -30;
                	break;
            	case 8:
	                rot = -45;
                	break;
            	case 9:
	                rot = -60;
                	break;
            	case 10:
	                rot = -75;
                	break;
            	case 11:
	                rot = -90;
                	break;
            	
            	default:
                	Debug.LogError("Unrecognized Option");
                	break;
        	}
        	switch (index2)
        	{
	            case 0:
    	            // Quaternion target = new Quaternion.Euler(rot, 0, 0);
    	            // obj.transform.rotation = Quaternion.Slerp(transform.rotation, target);
	            	rotNew = oldX + rot;
	            	obj.transform.Rotate(rotNew, oldY, oldZ);
        	        break;
            	case 1:
                	// Quaternion target = new Quaternion.Euler(0, rot, 0);
                	// obj.transform.rotation = Quaternion.Slerp(transform.rotation, target);
            		rotNew = oldY + rot;
            		obj.transform.Rotate(oldX, rotNew, oldZ);
                	break;
            	case 2:
	                // Quaternion target = new Quaternion.Euler(0, 0, rot);
	                // obj.transform.rotation = Quaternion.Slerp(transform.rotation, target);
            		rotNew = oldZ + rot;
            		obj.transform.Rotate(oldX, oldY, rotNew);
                	break;
            }
        }

	}
}
