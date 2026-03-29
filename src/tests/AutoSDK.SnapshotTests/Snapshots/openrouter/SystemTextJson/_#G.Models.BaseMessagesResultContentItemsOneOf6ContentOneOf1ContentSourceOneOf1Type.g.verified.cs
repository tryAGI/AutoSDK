//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1Type.Text,
                _ => null,
            };
        }
    }
}