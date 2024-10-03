//HintName: G.Models.ToolMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: tool
    /// </summary>
    public enum ToolMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageRole value)
        {
            return value switch
            {
                ToolMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ToolMessageRole.Tool,
                _ => null,
            };
        }
    }
}