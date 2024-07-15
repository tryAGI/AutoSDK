//HintName: G.Models.WebhookIssuesTransferredChangesNewRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewRepositoryOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesTransferredChangesNewRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewRepositoryOwnerType.Bot => "Bot",
                WebhookIssuesTransferredChangesNewRepositoryOwnerType.User => "User",
                WebhookIssuesTransferredChangesNewRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesTransferredChangesNewRepositoryOwnerType.Bot,
                "User" => WebhookIssuesTransferredChangesNewRepositoryOwnerType.User,
                "Organization" => WebhookIssuesTransferredChangesNewRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}