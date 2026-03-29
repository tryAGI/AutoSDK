//HintName: G.Models.PartialExpressiveAgentPresenterVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialExpressiveAgentPresenterVoiceElevenLabsType
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
    public static class PartialExpressiveAgentPresenterVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialExpressiveAgentPresenterVoiceElevenLabsType value)
        {
            return value switch
            {
                PartialExpressiveAgentPresenterVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialExpressiveAgentPresenterVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => PartialExpressiveAgentPresenterVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}