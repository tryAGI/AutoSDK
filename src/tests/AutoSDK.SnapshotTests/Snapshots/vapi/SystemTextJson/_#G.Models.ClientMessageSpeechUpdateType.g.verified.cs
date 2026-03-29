//HintName: G.Models.ClientMessageSpeechUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "speech-update" is sent whenever assistant or user start or stop speaking.
    /// </summary>
    public enum ClientMessageSpeechUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageSpeechUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageSpeechUpdateType value)
        {
            return value switch
            {
                ClientMessageSpeechUpdateType.SpeechUpdate => "speech-update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageSpeechUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "speech-update" => ClientMessageSpeechUpdateType.SpeechUpdate,
                _ => null,
            };
        }
    }
}