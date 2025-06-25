//HintName: G.Models.RealtimeSessionMaxResponseOutputTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionMaxResponseOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionMaxResponseOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionMaxResponseOutputTokens value)
        {
            return value switch
            {
                RealtimeSessionMaxResponseOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionMaxResponseOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeSessionMaxResponseOutputTokens.Inf,
                _ => null,
            };
        }
    }
}