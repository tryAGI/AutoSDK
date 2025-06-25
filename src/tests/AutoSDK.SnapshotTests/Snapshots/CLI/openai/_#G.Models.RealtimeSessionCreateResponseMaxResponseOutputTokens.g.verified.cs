//HintName: G.Models.RealtimeSessionCreateResponseMaxResponseOutputTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateResponseMaxResponseOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateResponseMaxResponseOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseMaxResponseOutputTokens value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseMaxResponseOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseMaxResponseOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeSessionCreateResponseMaxResponseOutputTokens.Inf,
                _ => null,
            };
        }
    }
}