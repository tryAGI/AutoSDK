//HintName: G.Models.ResponseNamedToolChoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. Currently, only `function` is supported.
    /// </summary>
    public enum ResponseNamedToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseNamedToolChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNamedToolChoiceType value)
        {
            return value switch
            {
                ResponseNamedToolChoiceType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNamedToolChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ResponseNamedToolChoiceType.Function,
                _ => null,
            };
        }
    }
}