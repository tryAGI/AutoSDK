//HintName: G.Models.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationPdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType.ApplicationPdf => "application/pdf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/pdf" => BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaType.ApplicationPdf,
                _ => null,
            };
        }
    }
}