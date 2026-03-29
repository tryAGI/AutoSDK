//HintName: G.Models.ExpressiveAgentPresenterVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveAgentPresenterVoiceElevenLabsType
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
    public static class ExpressiveAgentPresenterVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAgentPresenterVoiceElevenLabsType value)
        {
            return value switch
            {
                ExpressiveAgentPresenterVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAgentPresenterVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ExpressiveAgentPresenterVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}