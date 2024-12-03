//HintName: G.Models.DiscussionAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DiscussionAuthorAssociation
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
    public static class DiscussionAuthorAssociationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiscussionAuthorAssociation value)
        {
            return value switch
            {
                DiscussionAuthorAssociation.COLLABORATOR => "COLLABORATOR",
                DiscussionAuthorAssociation.CONTRIBUTOR => "CONTRIBUTOR",
                DiscussionAuthorAssociation.FIRSTTIMER => "FIRST_TIMER",
                DiscussionAuthorAssociation.FIRSTTIMECONTRIBUTOR => "FIRST_TIME_CONTRIBUTOR",
                DiscussionAuthorAssociation.MANNEQUIN => "MANNEQUIN",
                DiscussionAuthorAssociation.MEMBER => "MEMBER",
                DiscussionAuthorAssociation.NONE => "NONE",
                DiscussionAuthorAssociation.OWNER => "OWNER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscussionAuthorAssociation? ToEnum(string value)
        {
            return value switch
            {
                "COLLABORATOR" => DiscussionAuthorAssociation.COLLABORATOR,
                "CONTRIBUTOR" => DiscussionAuthorAssociation.CONTRIBUTOR,
                "FIRST_TIMER" => DiscussionAuthorAssociation.FIRSTTIMER,
                "FIRST_TIME_CONTRIBUTOR" => DiscussionAuthorAssociation.FIRSTTIMECONTRIBUTOR,
                "MANNEQUIN" => DiscussionAuthorAssociation.MANNEQUIN,
                "MEMBER" => DiscussionAuthorAssociation.MEMBER,
                "NONE" => DiscussionAuthorAssociation.NONE,
                "OWNER" => DiscussionAuthorAssociation.OWNER,
                _ => null,
            };
        }
    }
}