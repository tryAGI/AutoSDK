//HintName: G.Models.WebhookIssuesOpenedChangesOldRepositoryOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldRepositoryOwnerType
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
    public static class WebhookIssuesOpenedChangesOldRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldRepositoryOwnerType.Bot => "Bot",
                WebhookIssuesOpenedChangesOldRepositoryOwnerType.User => "User",
                WebhookIssuesOpenedChangesOldRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldRepositoryOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedChangesOldRepositoryOwnerType.Bot,
                "User" => WebhookIssuesOpenedChangesOldRepositoryOwnerType.User,
                "Organization" => WebhookIssuesOpenedChangesOldRepositoryOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}