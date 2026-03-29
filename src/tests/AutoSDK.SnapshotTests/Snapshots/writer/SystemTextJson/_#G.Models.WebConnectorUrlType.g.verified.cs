//HintName: G.Models.WebConnectorUrlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of web connector processing for a URL.
    /// </summary>
    public enum WebConnectorUrlType
    {
        /// <summary>
        /// 
        /// </summary>
        SinglePage,
        /// <summary>
        /// 
        /// </summary>
        SubPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebConnectorUrlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebConnectorUrlType value)
        {
            return value switch
            {
                WebConnectorUrlType.SinglePage => "single_page",
                WebConnectorUrlType.SubPages => "sub_pages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebConnectorUrlType? ToEnum(string value)
        {
            return value switch
            {
                "single_page" => WebConnectorUrlType.SinglePage,
                "sub_pages" => WebConnectorUrlType.SubPages,
                _ => null,
            };
        }
    }
}