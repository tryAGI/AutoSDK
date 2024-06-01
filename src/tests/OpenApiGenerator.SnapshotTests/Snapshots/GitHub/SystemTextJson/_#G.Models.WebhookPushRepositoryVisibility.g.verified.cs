//HintName: G.Models.WebhookPushRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPushRepositoryVisibility
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
    public static class WebhookPushRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPushRepositoryVisibility value)
        {
            return value switch
            {
                WebhookPushRepositoryVisibility.Public => "public",
                WebhookPushRepositoryVisibility.Private => "private",
                WebhookPushRepositoryVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPushRepositoryVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookPushRepositoryVisibility.Public,
                "private" => WebhookPushRepositoryVisibility.Private,
                "internal" => WebhookPushRepositoryVisibility.Internal,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}