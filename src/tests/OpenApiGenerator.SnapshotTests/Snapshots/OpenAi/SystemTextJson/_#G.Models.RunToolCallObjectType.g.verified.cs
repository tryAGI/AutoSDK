//HintName: G.Models.RunToolCallObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool call the output is required for. For now, this is always `function`.
    /// </summary>
    public enum RunToolCallObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunToolCallObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunToolCallObjectType value)
        {
            return value switch
            {
                RunToolCallObjectType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunToolCallObjectType? ToEnum(string value)
        {
            return value switch
            {
                "function" => RunToolCallObjectType.Function,
                _ => null,
            };
        }
    }
}