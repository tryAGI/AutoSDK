//HintName: G.Models.WebhookIssuesOpenedChangesOldRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldRepositoryVisibility
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
    public static class WebhookIssuesOpenedChangesOldRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldRepositoryVisibility value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldRepositoryVisibility.Public => "public",
                WebhookIssuesOpenedChangesOldRepositoryVisibility.Private => "private",
                WebhookIssuesOpenedChangesOldRepositoryVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookIssuesOpenedChangesOldRepositoryVisibility.Public,
                "private" => WebhookIssuesOpenedChangesOldRepositoryVisibility.Private,
                "internal" => WebhookIssuesOpenedChangesOldRepositoryVisibility.Internal,
                _ => null,
            };
        }
    }
}