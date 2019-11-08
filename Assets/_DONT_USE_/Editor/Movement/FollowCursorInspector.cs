﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(FollowCursor))]
public class FollowCursorInspector : BaseInspectorWindow
{
	private string explanation = "The gameObject moves towards the mouse cursor when the player clicks the left button.";

	public override void OnInspectorGUI()
	{
		GUILayout.Space(10);
		EditorGUILayout.HelpBox(explanation, MessageType.Info);

		base.OnInspectorGUI();
	}
}