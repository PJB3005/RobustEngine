using System;
using OpenTK;
using OpenTK.Audio.OpenAL;
namespace RobustEngine
{
	public class AudioBufferObject
	{
		public int channels { get; set; }
		public int bitsPerSample { get; set;}
		public int sampleRate { get; set;}
		public int bufferID {get; private set;}
		public byte[] soundData;

		public AudioBufferObject(byte[] soundData)
		{
			bufferID = AL.GenBuffer();
			this.soundData = soundData;
		}

		public void Clear()
		{
			AL.DeleteBuffer(this.bufferID);
			this.bufferID = AL.GenBuffer();
		}

		public void Build()
		{
			AL.BufferData(this.bufferID, GetSoundFormat(this.channels, this.bitsPerSample), this.soundData, this.soundData.Length, this.sampleRate);
		}

		//could use ferther overides fore different audio formats
		private ALFormat GetSoundFormat(int channels, int bitsPerSample)
		{
			ALFormat format = ALFormat.Mono8;//<-------------------------this needs to be made better.
			switch (channels)
			{
				case 1: if (bitsPerSample == 8) format = ALFormat.Mono8;
				else if (bitsPerSample == 16) format = ALFormat.Mono8;
					break;

				case 2: if (bitsPerSample == 8) format = ALFormat.Stereo8;
				else if(bitsPerSample == 16) format = ALFormat.Stereo16;
					break;
			}

			return format;
		}


	}
}
