//HintName: G.Models.ServerMessageSpeechUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "speech-update" is sent whenever assistant or user start or stop speaking.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessageSpeechUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech-update")]
        SpeechUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageSpeechUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageSpeechUpdateType value)
        {
            return value switch
            {
                ServerMessageSpeechUpdateType.SpeechUpdate => "speech-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageSpeechUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "speech-update" => ServerMessageSpeechUpdateType.SpeechUpdate,
                _ => null,
            };
        }
    }
}