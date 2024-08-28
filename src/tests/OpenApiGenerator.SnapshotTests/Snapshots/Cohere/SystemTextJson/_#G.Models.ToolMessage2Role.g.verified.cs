//HintName: G.Models.ToolMessage2Role.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolMessage2Role
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessage2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessage2Role value)
        {
            return value switch
            {
                ToolMessage2Role.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessage2Role? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ToolMessage2Role.Tool,
                _ => null,
            };
        }
    }
}