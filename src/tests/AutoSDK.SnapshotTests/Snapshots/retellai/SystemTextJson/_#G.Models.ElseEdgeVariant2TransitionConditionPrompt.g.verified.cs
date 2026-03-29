//HintName: G.Models.ElseEdgeVariant2TransitionConditionPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Must be "Else" for else edge
    /// </summary>
    public enum ElseEdgeVariant2TransitionConditionPrompt
    {
        /// <summary>
        /// 
        /// </summary>
        Else,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElseEdgeVariant2TransitionConditionPromptExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElseEdgeVariant2TransitionConditionPrompt value)
        {
            return value switch
            {
                ElseEdgeVariant2TransitionConditionPrompt.Else => "Else",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElseEdgeVariant2TransitionConditionPrompt? ToEnum(string value)
        {
            return value switch
            {
                "Else" => ElseEdgeVariant2TransitionConditionPrompt.Else,
                _ => null,
            };
        }
    }
}