//HintName: G.Models.WebhookIssuesClosedIssueIssue1AuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueIssue1AuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COLLABORATOR")]
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CONTRIBUTOR")]
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIMER")]
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRST_TIME_CONTRIBUTOR")]
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANNEQUIN")]
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MEMBER")]
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OWNER")]
        OWNER,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesClosedIssueIssue1AuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1AuthorAssociation value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1AuthorAssociation.COLLABORATOR => "COLLABORATOR",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.MANNEQUIN => "MANNEQUIN",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.MEMBER => "MEMBER",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.NONE => "NONE",
                WebhookIssuesClosedIssueIssue1AuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1AuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => WebhookIssuesClosedIssueIssue1AuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => WebhookIssuesClosedIssueIssue1AuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => WebhookIssuesClosedIssueIssue1AuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => WebhookIssuesClosedIssueIssue1AuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => WebhookIssuesClosedIssueIssue1AuthorAssociation.MANNEQUIN,
                "MEMBER" => WebhookIssuesClosedIssueIssue1AuthorAssociation.MEMBER,
                "NONE" => WebhookIssuesClosedIssueIssue1AuthorAssociation.NONE,
                "OWNER" => WebhookIssuesClosedIssueIssue1AuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}