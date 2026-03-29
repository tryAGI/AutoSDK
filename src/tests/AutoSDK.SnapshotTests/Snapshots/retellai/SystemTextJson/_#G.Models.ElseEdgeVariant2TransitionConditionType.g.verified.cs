//HintName: G.Models.ElseEdgeVariant2TransitionConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ElseEdgeVariant2TransitionConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElseEdgeVariant2TransitionConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElseEdgeVariant2TransitionConditionType value)
        {
            return value switch
            {
                ElseEdgeVariant2TransitionConditionType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElseEdgeVariant2TransitionConditionType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => ElseEdgeVariant2TransitionConditionType.Prompt,
                _ => null,
            };
        }
    }
}