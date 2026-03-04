//HintName: G.Models.WebhookPullRequestUnassignedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestUnassignedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestUnassignedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestUnassignedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}