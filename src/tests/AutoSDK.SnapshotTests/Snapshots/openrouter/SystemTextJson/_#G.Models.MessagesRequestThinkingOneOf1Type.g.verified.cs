//HintName: G.Models.MessagesRequestThinkingOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestThinkingOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestThinkingOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestThinkingOneOf1Type value)
        {
            return value switch
            {
                MessagesRequestThinkingOneOf1Type.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestThinkingOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => MessagesRequestThinkingOneOf1Type.Disabled,
                _ => null,
            };
        }
    }
}