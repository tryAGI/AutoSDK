//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType? ToEnum(string value)
        {
            return value switch
            {
                "document" => BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentType.Document,
                _ => null,
            };
        }
    }
}