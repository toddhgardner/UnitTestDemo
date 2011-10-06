using System;

namespace ShuttleControl.Exceptions
{
	public class ShuttleException : Exception
	{
		public ShuttleException(string message) : base(message)
		{
		}
	}
}