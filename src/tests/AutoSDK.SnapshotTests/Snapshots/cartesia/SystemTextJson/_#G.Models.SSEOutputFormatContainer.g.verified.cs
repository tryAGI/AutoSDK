//HintName: G.Models.SSEOutputFormatContainer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SSEOutputFormatContainer
    {
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SSEOutputFormatContainerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SSEOutputFormatContainer value)
        {
            return value switch
            {
                SSEOutputFormatContainer.Raw => "raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SSEOutputFormatContainer? ToEnum(string value)
        {
            return value switch
            {
                "raw" => SSEOutputFormatContainer.Raw,
                _ => null,
            };
        }
    }
}