//HintName: G.Models.ClientMessageSpeechUpdateStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the status of the speech update.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageSpeechUpdateStatus
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
    public static class ClientMessageSpeechUpdateStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageSpeechUpdateStatus value)
        {
            return value switch
            {
                ClientMessageSpeechUpdateStatus.Started => "started",
                ClientMessageSpeechUpdateStatus.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageSpeechUpdateStatus? ToEnum(string value)
        {
            return value switch
            {
                "started" => ClientMessageSpeechUpdateStatus.Started,
                "stopped" => ClientMessageSpeechUpdateStatus.Stopped,
                _ => null,
            };
        }
    }
}