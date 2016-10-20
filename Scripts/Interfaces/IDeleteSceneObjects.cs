﻿using System;

namespace UnityEngine.VR.Tools
{
	/// <summary>
	/// Decorates objects which can delete objects from the scene
	/// </summary>
	public interface IDeleteSceneObjects
	{
		/// <summary>
		/// Destroy the given game object and remove it from the spatial hash
		/// </summary>
		Action<GameObject> deleteSceneObject { set; }
	}
}