﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rain.Wave.Generators
{
	public sealed class LinearWaveGenerator
	{
		private readonly float _a;

		public LinearWaveGenerator(float a)
		{
			_a = a;
		}

		public float Probe(float time)
		{
			return _a * time;
		}
	}
}
