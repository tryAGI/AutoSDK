//HintName: G.Models.ToolParameterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type must be "object" for a JSON Schema object.
    /// </summary>
    public enum ToolParameterType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolParameterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolParameterType value)
        {
            return value switch
            {
                ToolParameterType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolParameterType? ToEnum(string value)
        {
            return value switch
            {
                "object" => ToolParameterType.Object,
                _ => null,
            };
        }
    }
}