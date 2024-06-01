//HintName: G.Models.DiscussionAuthorAssociation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum DiscussionAuthorAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        COLLABORATOR,
        /// <summary>
        /// 
        /// </summary>
        CONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMER,
        /// <summary>
        /// 
        /// </summary>
        FIRSTTIMECONTRIBUTOR,
        /// <summary>
        /// 
        /// </summary>
        MANNEQUIN,
        /// <summary>
        /// 
        /// </summary>
        MEMBER,
        /// <summary>
        /// 
        /// </summary>
        NONE,
        /// <summary>
        /// 
        /// </summary>
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
        public static DiscussionAuthorAssociation ToEnum(string value)
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
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}