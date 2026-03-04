//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestAutoMergeDisabledPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}