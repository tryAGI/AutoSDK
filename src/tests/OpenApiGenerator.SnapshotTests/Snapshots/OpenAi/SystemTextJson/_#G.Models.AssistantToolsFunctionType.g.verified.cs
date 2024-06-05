//HintName: G.Models.AssistantToolsFunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool being defined: `function`
    /// </summary>
    public enum AssistantToolsFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantToolsFunctionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantToolsFunctionType value)
        {
            return value switch
            {
                AssistantToolsFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantToolsFunctionType? ToEnum(string value)
        {
            return value switch
            {
                "function" => AssistantToolsFunctionType.Function,
                _ => null,
            };
        }
    }
}