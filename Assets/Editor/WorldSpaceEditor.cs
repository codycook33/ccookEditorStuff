using UnityEditor;
using UnityEngine;

public class WorldSpaceEditor : EditorWindow
{
   float xPos;
   float yPos;
   float zPos;
   float _xPos;
   float _yPos;
   float _zPos;
   float pPosX;
   float pPosY;
   float pPosZ;
   



	[MenuItem("Window/World Space")]
	public static void ShowWindow()
	{
		GetWindow<WorldSpaceEditor>("World Space");

	}
	public void OnGUI()
	{
		GameObject obj = Selection.activeGameObject;
		if (obj != null)
		{	
			if (obj.transform.parent != null)
			{
				pPosX = obj.transform.parent.transform.position.x;
				pPosY = obj.transform.parent.transform.position.y;
				pPosZ = obj.transform.parent.transform.position.z;
			}


			xPos = obj.transform.position.x;
			yPos = obj.transform.position.y;
			zPos = obj.transform.position.z;

		
			_xPos = EditorGUILayout.FloatField("WS X Position", xPos);

		
			_yPos = EditorGUILayout.FloatField("WS Y Position", yPos);

		
			_zPos = EditorGUILayout.FloatField("WS Z Position", zPos);

			EditorGUILayout.FloatField("Parents X Position", pPosX);

		
			EditorGUILayout.FloatField("Parents Y Position", pPosY);

		
			EditorGUILayout.FloatField("Parents Z Position", pPosZ);
			
			obj.transform.position = new Vector3(_xPos, _yPos, _zPos);
		}

		

		
	}


	

	



}

