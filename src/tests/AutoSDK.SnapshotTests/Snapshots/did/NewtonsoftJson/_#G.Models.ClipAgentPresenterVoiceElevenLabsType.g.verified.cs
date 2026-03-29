//HintName: G.Models.ClipAgentPresenterVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipAgentPresenterVoiceElevenLabsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClipAgentPresenterVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipAgentPresenterVoiceElevenLabsType value)
        {
            return value switch
            {
                ClipAgentPresenterVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipAgentPresenterVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ClipAgentPresenterVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}