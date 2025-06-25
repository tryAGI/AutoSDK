//HintName: G.Models.RealtimeResponseCreateParamsMaxResponseOutputTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeResponseCreateParamsMaxResponseOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseCreateParamsMaxResponseOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCreateParamsMaxResponseOutputTokens value)
        {
            return value switch
            {
                RealtimeResponseCreateParamsMaxResponseOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCreateParamsMaxResponseOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeResponseCreateParamsMaxResponseOutputTokens.Inf,
                _ => null,
            };
        }
    }
}