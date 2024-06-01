//HintName: G.Models.IssueSearchResultItemAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssueSearchResultItemAuthorAssociation
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
    public static class IssueSearchResultItemAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueSearchResultItemAuthorAssociation value)
        {
            return value switch
            {
                IssueSearchResultItemAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                IssueSearchResultItemAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                IssueSearchResultItemAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                IssueSearchResultItemAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                IssueSearchResultItemAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                IssueSearchResultItemAuthorAssociation.MEMBER => "MEMBER",
                IssueSearchResultItemAuthorAssociation.NONE => "NONE",
                IssueSearchResultItemAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueSearchResultItemAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => IssueSearchResultItemAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => IssueSearchResultItemAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => IssueSearchResultItemAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => IssueSearchResultItemAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => IssueSearchResultItemAuthorAssociation.MANNEQUIN,
                "MEMBER" => IssueSearchResultItemAuthorAssociation.MEMBER,
                "NONE" => IssueSearchResultItemAuthorAssociation.NONE,
                "OWNER" => IssueSearchResultItemAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}