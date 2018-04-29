﻿using System;
using Microsoft.Extensions.Logging;

namespace net.vieapps.Components.WebSockets
{
	public static class Logger
	{
		static ILoggerFactory LoggerFactory;

		/// <summary>
		/// Assigns a logger factory
		/// </summary>
		/// <param name="loggerFactory"></param>
		public static void AssignLoggerFactory(ILoggerFactory loggerFactory)
		{
			if (Logger.LoggerFactory == null && loggerFactory != null)
				Logger.LoggerFactory = loggerFactory;
		}

		/// <summary>
		/// Gets a logger factory
		/// </summary>
		/// <returns></returns>
		public static ILoggerFactory GetLoggerFactory()
		{
			return Logger.LoggerFactory ?? new NullLoggerFactory();
		}

		/// <summary>
		/// Creates a logger
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static ILogger CreateLogger(Type type)
		{
			return Logger.GetLoggerFactory().CreateLogger(type);
		}

		/// <summary>
		/// Creates a logger
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <returns></returns>
		public static ILogger CreateLogger<T>()
		{
			return Logger.CreateLogger(typeof(T));
		}
	}

	#region NullLogger

	public class NullLoggerFactory : ILoggerFactory
	{
		public void AddProvider(ILoggerProvider provider) { }

		public ILogger CreateLogger(string categoryName)
		{
			return NullLogger.Instance;
		}

		public void Dispose() { }
	}

	public class NullLogger : ILogger
	{
		internal static NullLogger Instance = new NullLogger();

		private NullLogger() { }

		public IDisposable BeginScope<TState>(TState state) { return null; }

		public bool IsEnabled(LogLevel logLevel)
		{
			return false;
		}

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) { }
	}
	#endregion

}