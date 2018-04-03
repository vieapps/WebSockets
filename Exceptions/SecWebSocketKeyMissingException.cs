﻿using System;
using System.Collections.Generic;
using System.Text;

namespace net.vieapps.Components.WebSockets.Exceptions
{
    [Serializable]
    public class SecWebSocketKeyMissingException : Exception
    {
        public SecWebSocketKeyMissingException() : base()
        {

        }

        public SecWebSocketKeyMissingException(string message) : base(message)
        {

        }

        public SecWebSocketKeyMissingException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
