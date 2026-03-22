//HintName: G.Models.WebhookIssuesOpenedChangesOldRepositoryVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldRepositoryVisibility
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
    public static class WebhookIssuesOpenedChangesOldRepositoryVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldRepositoryVisibility value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldRepositoryVisibility.Internal => "internal",
                WebhookIssuesOpenedChangesOldRepositoryVisibility.Private => "private",
                WebhookIssuesOpenedChangesOldRepositoryVisibility.Public => "public",
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
                "internal" => WebhookIssuesOpenedChangesOldRepositoryVisibility.Internal,
                "private" => WebhookIssuesOpenedChangesOldRepositoryVisibility.Private,
                "public" => WebhookIssuesOpenedChangesOldRepositoryVisibility.Public,
                _ => null,
            };
        }
    }
}