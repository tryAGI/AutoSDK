//HintName: G.Models.WebhookIssuesTransferredChangesNewRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesTransferredChangesNewRepositoryVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="internal")]
        Internal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
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
                WebhookIssuesTransferredChangesNewRepositoryVisibility.Internal => "internal",
                WebhookIssuesTransferredChangesNewRepositoryVisibility.Private => "private",
                WebhookIssuesTransferredChangesNewRepositoryVisibility.Public => "public",
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
                "internal" => WebhookIssuesTransferredChangesNewRepositoryVisibility.Internal,
                "private" => WebhookIssuesTransferredChangesNewRepositoryVisibility.Private,
                "public" => WebhookIssuesTransferredChangesNewRepositoryVisibility.Public,
                _ => null,
            };
        }
    }
}