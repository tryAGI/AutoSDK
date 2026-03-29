//HintName: G.Models.ServerMessageHandoffDestinationRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "handoff-destination-request" is sent when the model is requesting handoff but destination is unknown.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageHandoffDestinationRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="handoff-destination-request")]
        HandoffDestinationRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageHandoffDestinationRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageHandoffDestinationRequestType value)
        {
            return value switch
            {
                ServerMessageHandoffDestinationRequestType.HandoffDestinationRequest => "handoff-destination-request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageHandoffDestinationRequestType? ToEnum(string value)
        {
            return value switch
            {
                "handoff-destination-request" => ServerMessageHandoffDestinationRequestType.HandoffDestinationRequest,
                _ => null,
            };
        }
    }
}