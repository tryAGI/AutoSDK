//HintName: G.Models.RealtimeResponseMaxOutputTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeResponseMaxOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseMaxOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseMaxOutputTokens value)
        {
            return value switch
            {
                RealtimeResponseMaxOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseMaxOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeResponseMaxOutputTokens.Inf,
                _ => null,
            };
        }
    }
}