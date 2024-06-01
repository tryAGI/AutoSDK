//HintName: G.Models.ReactionsListForTeamDiscussionCommentInOrgContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactionsListForTeamDiscussionCommentInOrgContent
    {
        /// <summary>
        /// 
        /// </summary>
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        Minus1,
        /// <summary>
        /// 
        /// </summary>
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        Confused,
        /// <summary>
        /// 
        /// </summary>
        Heart,
        /// <summary>
        /// 
        /// </summary>
        Hooray,
        /// <summary>
        /// 
        /// </summary>
        Rocket,
        /// <summary>
        /// 
        /// </summary>
        Eyes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReactionsListForTeamDiscussionCommentInOrgContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForTeamDiscussionCommentInOrgContent value)
        {
            return value switch
            {
                ReactionsListForTeamDiscussionCommentInOrgContent.Plus1 => "+1",
                ReactionsListForTeamDiscussionCommentInOrgContent.Minus1 => "-1",
                ReactionsListForTeamDiscussionCommentInOrgContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionCommentInOrgContent.Confused => "confused",
                ReactionsListForTeamDiscussionCommentInOrgContent.Heart => "heart",
                ReactionsListForTeamDiscussionCommentInOrgContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionCommentInOrgContent.Rocket => "rocket",
                ReactionsListForTeamDiscussionCommentInOrgContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForTeamDiscussionCommentInOrgContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForTeamDiscussionCommentInOrgContent.Plus1,
                "-1" => ReactionsListForTeamDiscussionCommentInOrgContent.Minus1,
                "laugh" => ReactionsListForTeamDiscussionCommentInOrgContent.Laugh,
                "confused" => ReactionsListForTeamDiscussionCommentInOrgContent.Confused,
                "heart" => ReactionsListForTeamDiscussionCommentInOrgContent.Heart,
                "hooray" => ReactionsListForTeamDiscussionCommentInOrgContent.Hooray,
                "rocket" => ReactionsListForTeamDiscussionCommentInOrgContent.Rocket,
                "eyes" => ReactionsListForTeamDiscussionCommentInOrgContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}