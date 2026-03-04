//HintName: G.Models.WebhookPullRequestAssignedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAssignedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestAssignedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestAssignedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestAssignedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestAssignedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestAssignedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestAssignedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}