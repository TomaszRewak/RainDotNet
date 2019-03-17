﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rain.Wave.Transformers
{
	public sealed class PhaseWaveTransformer : IWave
	{
		private readonly float _offset;
		private readonly IWave _baseWave;

		public PhaseWaveTransformer(float offset, IWave baseWave)
		{
			_offset = offset;
			_baseWave = baseWave;
		}

		public float Probe(float time)
		{
			return _baseWave.Probe(time + _offset);
		}
	}
}