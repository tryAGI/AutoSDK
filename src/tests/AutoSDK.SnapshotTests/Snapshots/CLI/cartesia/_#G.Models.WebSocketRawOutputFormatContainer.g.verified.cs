//HintName: G.Models.WebSocketRawOutputFormatContainer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSocketRawOutputFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSocketRawOutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSocketRawOutputFormatContainer value)
        {
            return value switch
            {
                WebSocketRawOutputFormatContainer.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSocketRawOutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "raw" => WebSocketRawOutputFormatContainer.Raw,
                _ => null,
            };
        }
    }
}