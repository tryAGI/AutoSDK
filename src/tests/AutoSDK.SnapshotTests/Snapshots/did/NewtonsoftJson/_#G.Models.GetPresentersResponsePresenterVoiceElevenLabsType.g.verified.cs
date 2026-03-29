//HintName: G.Models.GetPresentersResponsePresenterVoiceElevenLabsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPresentersResponsePresenterVoiceElevenLabsType
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
    public static class GetPresentersResponsePresenterVoiceElevenLabsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresentersResponsePresenterVoiceElevenLabsType value)
        {
            return value switch
            {
                GetPresentersResponsePresenterVoiceElevenLabsType.Elevenlabs => "elevenlabs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresentersResponsePresenterVoiceElevenLabsType? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => GetPresentersResponsePresenterVoiceElevenLabsType.Elevenlabs,
                _ => null,
            };
        }
    }
}