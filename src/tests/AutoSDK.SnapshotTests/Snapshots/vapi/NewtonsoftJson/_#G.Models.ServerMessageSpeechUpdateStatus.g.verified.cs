//HintName: G.Models.ServerMessageSpeechUpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the speech update.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageSpeechUpdateStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stopped")]
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageSpeechUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageSpeechUpdateStatus value)
        {
            return value switch
            {
                ServerMessageSpeechUpdateStatus.Started => "started",
                ServerMessageSpeechUpdateStatus.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageSpeechUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "started" => ServerMessageSpeechUpdateStatus.Started,
                "stopped" => ServerMessageSpeechUpdateStatus.Stopped,
                _ => null,
            };
        }
    }
}