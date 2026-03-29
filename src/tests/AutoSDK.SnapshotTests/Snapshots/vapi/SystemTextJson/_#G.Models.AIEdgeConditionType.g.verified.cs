//HintName: G.Models.AIEdgeConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AIEdgeConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AIEdgeConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AIEdgeConditionType value)
        {
            return value switch
            {
                AIEdgeConditionType.Ai => "ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AIEdgeConditionType? ToEnum(string value)
        {
            return value switch
            {
                "ai" => AIEdgeConditionType.Ai,
                _ => null,
            };
        }
    }
}