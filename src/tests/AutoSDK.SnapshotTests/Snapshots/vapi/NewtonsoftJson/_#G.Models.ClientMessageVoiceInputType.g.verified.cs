//HintName: G.Models.ClientMessageVoiceInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "voice-input" is sent when a generation is requested from voice provider.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientMessageVoiceInputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice-input")]
        VoiceInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageVoiceInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageVoiceInputType value)
        {
            return value switch
            {
                ClientMessageVoiceInputType.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageVoiceInputType? ToEnum(string value)
        {
            return value switch
            {
                "voice-input" => ClientMessageVoiceInputType.VoiceInput,
                _ => null,
            };
        }
    }
}