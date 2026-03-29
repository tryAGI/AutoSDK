//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0MediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0MediaType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationPdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0MediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0MediaType value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0MediaType.ApplicationPdf => "application/pdf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0MediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/pdf" => MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0MediaType.ApplicationPdf,
                _ => null,
            };
        }
    }
}