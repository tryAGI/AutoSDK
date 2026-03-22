//HintName: G.Models.ServerEventDiscriminatorMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerEventDiscriminatorMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="committed_transcript")]
        CommittedTranscript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partial_transcript")]
        PartialTranscript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session_started")]
        SessionStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorMessageType value)
        {
            return value switch
            {
                ServerEventDiscriminatorMessageType.CommittedTranscript => "committed_transcript",
                ServerEventDiscriminatorMessageType.Error => "error",
                ServerEventDiscriminatorMessageType.PartialTranscript => "partial_transcript",
                ServerEventDiscriminatorMessageType.SessionStarted => "session_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorMessageType? ToEnum(string value)
        {
            return value switch
            {
                "committed_transcript" => ServerEventDiscriminatorMessageType.CommittedTranscript,
                "error" => ServerEventDiscriminatorMessageType.Error,
                "partial_transcript" => ServerEventDiscriminatorMessageType.PartialTranscript,
                "session_started" => ServerEventDiscriminatorMessageType.SessionStarted,
                _ => null,
            };
        }
    }
}