//HintName: G.Models.FallbackTavusVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackTavusVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        R52da2535a,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackTavusVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackTavusVoiceVoiceId value)
        {
            return value switch
            {
                FallbackTavusVoiceVoiceId.R52da2535a => "r52da2535a",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackTavusVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "r52da2535a" => FallbackTavusVoiceVoiceId.R52da2535a,
                _ => null,
            };
        }
    }
}