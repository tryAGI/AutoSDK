//HintName: G.Models.WebhookIssuesTransferredChangesNewRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewRepositoryVisibility
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
    public static class WebhookIssuesTransferredChangesNewRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewRepositoryVisibility value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewRepositoryVisibility.Public => "public",
                WebhookIssuesTransferredChangesNewRepositoryVisibility.Private => "private",
                WebhookIssuesTransferredChangesNewRepositoryVisibility.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewRepositoryVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => WebhookIssuesTransferredChangesNewRepositoryVisibility.Public,
                "private" => WebhookIssuesTransferredChangesNewRepositoryVisibility.Private,
                "internal" => WebhookIssuesTransferredChangesNewRepositoryVisibility.Internal,
                _ => null,
            };
        }
    }
}