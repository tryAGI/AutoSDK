//HintName: G.Models.RealtimeSessionCreateRequestMaxResponseOutputTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateRequestMaxResponseOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestMaxResponseOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestMaxResponseOutputTokens value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestMaxResponseOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestMaxResponseOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeSessionCreateRequestMaxResponseOutputTokens.Inf,
                _ => null,
            };
        }
    }
}