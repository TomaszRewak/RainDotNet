﻿using NAudio.Wave;
using WaveDotNet.Generator;
using WaveDotNet.Wave.Combiners;
using WaveDotNet.Wave.Filters;
using WaveDotNet.Wave.Generators;
using WaveDotNet.Wave.Transformers;
using System.Threading;

namespace WaveDotNet.Sandbox
{
	class Program
	{
		static void Main(string[] args)
		{
			//var backgroundWaveDotNetWave =
			//	new AmplitudeWaveTransformer(
			//		multiplier: 0.2f,
			//		offset: 0.0f,
			//		baseWave: new MultiplicationWaveCombiner(
			//			new AmplitudeWaveFilter(
			//				maxAmplitude: 0.75f,
			//				baseWave: new SquareWaveFilter(
			//					baseWave: new WhiteNoiseWaveGenerator())),
			//			new AmplitudeWaveTransformer(
			//				multiplier: 0.2f,
			//				offset: 0.8f,
			//				baseWave: new MultiplicationWaveCombiner(
			//					new FrequencyWaveTransformer(
			//						frequency: 0.25f,
			//						baseWave: new SinWaveGenerator()),
			//					new FrequencyWaveTransformer(
			//						frequency: 0.13f,
			//						baseWave: new SinWaveGenerator()),
			//					new FrequencyWaveTransformer(
			//						frequency: 0.07f,
			//						baseWave: new SinWaveGenerator())))));

			//var waveProvider = new WaveProvider(
			//	sampleRate: 16000,
			//	channels: new[] {
			//		new AdditiveWaveCombiner(
			//			new AmplitudeWaveTransformer(1.0f, 0.0f, backgroundWaveDotNetWave),
			//			new PhaseWaveTransformer(0.5f, new AmplitudeWaveTransformer(0.5f, 0.0f, backgroundWaveDotNetWave))),

			//		new AdditiveWaveCombiner(
			//			new AmplitudeWaveTransformer(0.5f, 0.0f, backgroundWaveDotNetWave),
			//			new PhaseWaveTransformer(0.5f, new AmplitudeWaveTransformer(1.0f, 0.0f, backgroundWaveDotNetWave)))
			//	});

			//var wave = new WhiteNoiseWaveGenerator(1);

			//using (var wo = new WavePlayer(wave))
			//{
			//	wo.Play();

			//	while (true)
			//		Thread.Sleep(500);
			//}
		}
	}
}