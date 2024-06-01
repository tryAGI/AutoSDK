//HintName: G.Models.IssueAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// <br/>Example: OWNER
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IssueAuthorAssociation
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
    public static class IssueAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IssueAuthorAssociation value)
        {
            return value switch
            {
                IssueAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                IssueAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                IssueAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                IssueAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                IssueAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                IssueAuthorAssociation.MEMBER => "MEMBER",
                IssueAuthorAssociation.NONE => "NONE",
                IssueAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IssueAuthorAssociation ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => IssueAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => IssueAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => IssueAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => IssueAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => IssueAuthorAssociation.MANNEQUIN,
                "MEMBER" => IssueAuthorAssociation.MEMBER,
                "NONE" => IssueAuthorAssociation.NONE,
                "OWNER" => IssueAuthorAssociation.OWNER,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}