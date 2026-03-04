//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestEnqueuedPullRequestAuthorAssociation
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
    public static class WebhookPullRequestEnqueuedPullRequestAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestAuthorAssociation value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Collaborator => "COLLABORATOR",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Contributor => "CONTRIBUTOR",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.FirstTimer => "FIRST_TIMER",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.FirstTimeContributor => "FIRST_TIME_CONTRIBUTOR",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Mannequin => "MANNEQUIN",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Member => "MEMBER",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.None => "NONE",
                WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Owner => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Collaborator,
                "CONTRIBUTOR" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Contributor,
                "FIRST_TIMER" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.FirstTimer,
                "FIRST_TIME_CONTRIBUTOR" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.FirstTimeContributor,
                "MANNEQUIN" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Mannequin,
                "MEMBER" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Member,
                "NONE" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.None,
                "OWNER" => WebhookPullRequestEnqueuedPullRequestAuthorAssociation.Owner,
                _ => null,
            };
        }
    }
}