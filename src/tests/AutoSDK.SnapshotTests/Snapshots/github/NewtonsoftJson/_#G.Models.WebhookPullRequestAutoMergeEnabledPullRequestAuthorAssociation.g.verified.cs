//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COLLABORATOR")]
        Collaborator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTRIBUTOR")]
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIMER")]
        FirstTimer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIME_CONTRIBUTOR")]
        FirstTimeContributor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANNEQUIN")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestAutoMergeEnabledPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}