//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType
    {
        /// <summary>
        /// 
        /// </summary>
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType? ToEnum(string value)
        {
            return value switch
            {
                "text/plain" => BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaType.TextPlain,
                _ => null,
            };
        }
    }
}