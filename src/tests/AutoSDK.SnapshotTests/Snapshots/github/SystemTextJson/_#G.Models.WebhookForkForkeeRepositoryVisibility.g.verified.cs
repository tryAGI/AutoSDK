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
    public static class WebhookForkForkeeRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookForkForkeeRepositoryVisibility value)
        {
            return value switch
            {
                WebhookForkForkeeRepositoryVisibility.Public => "public",
                WebhookForkForkeeRepositoryVisibility.Private => "private",
                WebhookForkForkeeRepositoryVisibility.Internal => "internal",
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
                "public" => WebhookForkForkeeRepositoryVisibility.Public,
                "private" => WebhookForkForkeeRepositoryVisibility.Private,
                "internal" => WebhookForkForkeeRepositoryVisibility.Internal,
                _ => null,
            };
        }
    }
}