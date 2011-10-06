using System;
using ShuttleControl.Exceptions;

namespace ShuttleControl.Models
{
	public class Shuttle
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string SerialNumber { get; set; }

		public string Payload { get; set; }

		public bool HasLaunched { get; set; }

		public DateTime? LaunchedOn { get; set; }

		public DateTime? LandedOn { get; set; }

		public void Launch()
		{
			if (this.IsReadyToLaunch())
			{
				this.HasLaunched = true;
				this.LaunchedOn = DateTime.UtcNow;
				this.LandedOn = null;
				return;
			}

			throw new ShuttleException("Shuttle attempted to launch, but was not ready");
		}

		public void Land()
		{
			if (this.IsReadyToLand())
			{
				this.HasLaunched = false;
				this.LaunchedOn = null;
				this.LandedOn = DateTime.UtcNow;
				return;
			}

			throw new ShuttleException("Shuttle attempted to land, but was not ready");
		}

		public void LoadPayload(string payload)
		{
			if(this.IsReadyToLoad())
			{
				this.Payload = payload;
				return;
			}

			throw new ShuttleException("Shuttle attempted to load a payload, but was not ready");
		}

		public void ReleasePayload()
		{
			if (this.IsReadyToRelease())
			{
				this.Payload = string.Empty;
				return;
			}

			throw new ShuttleException("Shuttle attempted to release a payload, but was not ready");
		}

		public bool IsReadyToLoad()
		{
			return (!this.HasLaunched && string.IsNullOrEmpty(this.Payload));
		}

		public bool IsReadyToLaunch()
		{
			return (!this.HasLaunched && !string.IsNullOrEmpty(this.Payload));
		}

		public bool IsReadyToLand()
		{
			return (this.HasLaunched && string.IsNullOrEmpty(this.Payload));
		}

		public bool IsReadyToRelease()
		{
			return (this.HasLaunched && !string.IsNullOrEmpty(this.Payload));
		}
	}
}