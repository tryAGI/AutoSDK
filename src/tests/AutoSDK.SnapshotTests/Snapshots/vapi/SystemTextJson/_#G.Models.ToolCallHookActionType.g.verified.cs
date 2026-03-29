//HintName: G.Models.ToolCallHookActionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of action - must be "tool"
    /// </summary>
    public enum ToolCallHookActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallHookActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallHookActionType value)
        {
            return value switch
            {
                ToolCallHookActionType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallHookActionType? ToEnum(string value)
        {
            return value switch
            {
                "tool" => ToolCallHookActionType.Tool,
                _ => null,
            };
        }
    }
}