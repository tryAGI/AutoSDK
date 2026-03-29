//HintName: G.Models.TavusVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TavusVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        R52da2535a,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TavusVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TavusVoiceVoiceId value)
        {
            return value switch
            {
                TavusVoiceVoiceId.R52da2535a => "r52da2535a",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TavusVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "r52da2535a" => TavusVoiceVoiceId.R52da2535a,
                _ => null,
            };
        }
    }
}