//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf6Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf6Type
    {
        /// <summary>
        /// 
        /// </summary>
        RedactedThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf6Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf6Type.RedactedThinking => "redacted_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf6Type? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => MessagesMessageParamContentOneOf1ItemsOneOf6Type.RedactedThinking,
                _ => null,
            };
        }
    }
}