using System;
using UnityEngine;

namespace Assets.MoveableLineRenderer.Scripts
{
	internal static class TurbulenceUtil
	{
		public static Vector3 Calc(Vector3 position, float speed, float scale, float height, float gravity)
		{
			var sTime = Time.timeSinceLevelLoad * speed;

			float xCoord = position.x * scale + sTime;
			float yCoord = position.y * scale + sTime;
			float zCoord = position.z * scale + sTime;

			position.x += (Mathf.PerlinNoise(yCoord, zCoord) - 0.5f) * height;
			position.y += (Mathf.PerlinNoise(xCoord, zCoord) - 0.5f) * height - gravity;
			position.z += (Mathf.PerlinNoise(xCoord, yCoord) - 0.5f) * height;

			return position;
		}
	}
}