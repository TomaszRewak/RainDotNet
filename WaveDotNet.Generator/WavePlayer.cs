﻿using NAudio.Wave;
using WaveDotNet.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaveDotNet.Generator
{
	public class WavePlayer : IDisposable
	{
		private readonly IWavePlayer _player;

		public WavePlayer(IWave wave, int sampleRate = 48000) :
			this(new WaveProvider(sampleRate, new[] { wave }))
		{ }

		internal WavePlayer(IWaveProvider waveProvider)
		{
			_player = new WaveOutEvent();
			_player.Init(waveProvider);
		}

		public void Play()
		{
			_player.Play();
		}

		public void Stop()
		{
			_player.Stop();
			_player.Pause();
		}

		public void Dispose()
		{
			_player.Dispose();
		}
	}
}