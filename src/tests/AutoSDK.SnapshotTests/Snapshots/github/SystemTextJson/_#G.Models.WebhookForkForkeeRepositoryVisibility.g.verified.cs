//HintName: G.Models.WebhookForkForkeeRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookForkForkeeRepositoryVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookForkForkeeRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookForkForkeeRepositoryVisibility value)
        {
            return value switch
            {
                WebhookForkForkeeRepositoryVisibility.Internal => "internal",
                WebhookForkForkeeRepositoryVisibility.Private => "private",
                WebhookForkForkeeRepositoryVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookForkForkeeRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => WebhookForkForkeeRepositoryVisibility.Internal,
                "private" => WebhookForkForkeeRepositoryVisibility.Private,
                "public" => WebhookForkForkeeRepositoryVisibility.Public,
                _ => null,
            };
        }
    }
}