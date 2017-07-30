using System;
using OpenTK;
using OpenTK.Audio.OpenAL;
namespace RobustEngine
{
	public class AudioSourceObject
	{
		int sourceID;
		int[] buffers;

		public AudioSourceObject()
		{
			sourceID = AL.GenSource();
		}

		public void Build()
		{
			foreach (int bufferID in buffers)
				AL.Source(this.sourceID, ALSourcei.Buffer, buffers[bufferID]);
		}

		public void QueueBuffer(AudioBufferObject buffer)
		{
			AL.SourceQueueBuffer(this.sourceID, buffer.bufferID);
		}

		public void Play()
		{
			AL.SourcePlay(this.sourceID);
		}

		public void Pause()
		{
			AL.SourcePause(this.sourceID);
		}

		public void Stop()
		{
			AL.SourceStop(this.sourceID);
		}

		public void Rewind()
		{
			AL.SourceRewind(this.sourceID);
		}

	}
}
