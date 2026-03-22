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
        Confused,
        /// <summary>
        /// 
        /// </summary>
        Eyes,
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
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        Rocket,
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
                ReactionsListForTeamDiscussionCommentInOrgContent.Confused => "confused",
                ReactionsListForTeamDiscussionCommentInOrgContent.Eyes => "eyes",
                ReactionsListForTeamDiscussionCommentInOrgContent.Heart => "heart",
                ReactionsListForTeamDiscussionCommentInOrgContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionCommentInOrgContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionCommentInOrgContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForTeamDiscussionCommentInOrgContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForTeamDiscussionCommentInOrgContent.Plus1,
                "-1" => ReactionsListForTeamDiscussionCommentInOrgContent.Minus1,
                "confused" => ReactionsListForTeamDiscussionCommentInOrgContent.Confused,
                "eyes" => ReactionsListForTeamDiscussionCommentInOrgContent.Eyes,
                "heart" => ReactionsListForTeamDiscussionCommentInOrgContent.Heart,
                "hooray" => ReactionsListForTeamDiscussionCommentInOrgContent.Hooray,
                "laugh" => ReactionsListForTeamDiscussionCommentInOrgContent.Laugh,
                "rocket" => ReactionsListForTeamDiscussionCommentInOrgContent.Rocket,
                _ => null,
            };
        }
    }
}