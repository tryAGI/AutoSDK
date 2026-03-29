//HintName: G.Models.ServerMessageCallEndpointingRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "call.endpointing.request" is sent when using `assistant.startSpeakingPlan.smartEndpointingPlan={ "provider": "custom-endpointing-model" }`.<br/>
    /// Here is what the request will look like:<br/>
    /// POST https://{assistant.startSpeakingPlan.smartEndpointingPlan.server.url}<br/>
    /// Content-Type: application/json<br/>
    /// {<br/>
    ///   "message": {<br/>
    ///     "type": "call.endpointing.request",<br/>
    ///     "messages": [<br/>
    ///       {<br/>
    ///         "role": "user",<br/>
    ///         "message": "Hello, how are you?",<br/>
    ///         "time": 1234567890,<br/>
    ///         "secondsFromStart": 0<br/>
    ///       }<br/>
    ///     ],<br/>
    ///     ...other metadata about the call...<br/>
    ///   }<br/>
    /// }<br/>
    /// The expected response:<br/>
    /// {<br/>
    ///   "timeoutSeconds": 0.5<br/>
    /// }
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageCallEndpointingRequestType
    {
        /// <summary>
        /// "custom-endpointing-model" }`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.endpointing.request")]
        CallEndpointingRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageCallEndpointingRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageCallEndpointingRequestType value)
        {
            return value switch
            {
                ServerMessageCallEndpointingRequestType.CallEndpointingRequest => "call.endpointing.request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageCallEndpointingRequestType? ToEnum(string value)
        {
            return value switch
            {
                "call.endpointing.request" => ServerMessageCallEndpointingRequestType.CallEndpointingRequest,
                _ => null,
            };
        }
    }
}