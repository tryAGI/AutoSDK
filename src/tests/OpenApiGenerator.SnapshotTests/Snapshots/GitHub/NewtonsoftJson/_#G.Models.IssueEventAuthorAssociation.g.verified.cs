//HintName: G.Models.IssueEventAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssueEventAuthorAssociation
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
    public static class IssueEventAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueEventAuthorAssociation value)
        {
            return value switch
            {
                IssueEventAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                IssueEventAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                IssueEventAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                IssueEventAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                IssueEventAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                IssueEventAuthorAssociation.MEMBER => "MEMBER",
                IssueEventAuthorAssociation.NONE => "NONE",
                IssueEventAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueEventAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => IssueEventAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => IssueEventAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => IssueEventAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => IssueEventAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => IssueEventAuthorAssociation.MANNEQUIN,
                "MEMBER" => IssueEventAuthorAssociation.MEMBER,
                "NONE" => IssueEventAuthorAssociation.NONE,
                "OWNER" => IssueEventAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}