using System;
using OpenTK;
using OpenTK.Audio.OpenAL;
namespace RobustEngine
{
	public class AudioBufferObject
	{
		int channels;
		int bitsPerSample;
		int sampleRate;
		int buffer;
		byte[] soundData;

		public AudioBufferObject(byte[] soundData)
		{
			buffer = AL.GenBuffer();
			this.soundData = soundData;
		}

		public void Clear()
		{

		}

		//could use ferther overides fore different audio formats
		private ALFormat? GetSoundFormat(int channels, int bitsPerSample)
		{
			ALFormat? format = null;
			switch (channels)
			{
				case 1: if (bitsPerSample == 8) format = ALFormat.Mono8;
					else format = ALFormat.Mono8;
					break;

				case 2: if (bitsPerSample == 8) format = ALFormat.Stereo8;
					else format = ALFormat.Stereo16;
					break;
			}

			return format;
		}


	}
}
null