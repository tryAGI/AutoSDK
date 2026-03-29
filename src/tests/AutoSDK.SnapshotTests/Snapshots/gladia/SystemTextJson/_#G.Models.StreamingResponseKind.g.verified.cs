//HintName: G.Models.StreamingResponseKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: live<br/>
    /// Example: live
    /// </summary>
    public enum StreamingResponseKind
    {
        /// <summary>
        /// 
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamingResponseKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamingResponseKind value)
        {
            return value switch
            {
                StreamingResponseKind.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamingResponseKind? ToEnum(string value)
        {
            return value switch
            {
                "live" => StreamingResponseKind.Live,
                _ => null,
            };
        }
    }
}