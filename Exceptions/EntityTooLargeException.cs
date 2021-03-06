﻿using System;

namespace net.vieapps.Components.WebSockets.Exceptions
{
	[Serializable]
	public class EntityTooLargeException : Exception
	{
		public EntityTooLargeException() : base() { }

		/// <summary>
		/// HTTP header too large to fit in buffer
		/// </summary>
		public EntityTooLargeException(string message) : base(message) { }

		public EntityTooLargeException(string message, Exception inner) : base(message, inner) { }
	}
}
