//HintName: G.Models.WebhookForkForkeeVariant1Visibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookForkForkeeVariant1Visibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookForkForkeeVariant1VisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookForkForkeeVariant1Visibility value)
        {
            return value switch
            {
                WebhookForkForkeeVariant1Visibility.Public => "public",
                WebhookForkForkeeVariant1Visibility.Private => "private",
                WebhookForkForkeeVariant1Visibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookForkForkeeVariant1Visibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookForkForkeeVariant1Visibility.Public,
                "private" => WebhookForkForkeeVariant1Visibility.Private,
                "internal" => WebhookForkForkeeVariant1Visibility.Internal,
                _ => null,
            };
        }
    }
}