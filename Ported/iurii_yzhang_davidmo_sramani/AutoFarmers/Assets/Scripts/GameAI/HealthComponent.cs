﻿using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace GameAI
{
	public struct HealthComponent : IComponentData
	{
		int health;
	};
}