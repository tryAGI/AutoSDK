//HintName: G.Models.ToolCallStreamingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallStreamingType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallStreamingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallStreamingType value)
        {
            return value switch
            {
                ToolCallStreamingType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallStreamingType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolCallStreamingType.Function,
                _ => null,
            };
        }
    }
}