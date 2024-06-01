//HintName: G.Models.ReactionsListForTeamDiscussionCommentLegacyContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactionsListForTeamDiscussionCommentLegacyContent
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
    public static class ReactionsListForTeamDiscussionCommentLegacyContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForTeamDiscussionCommentLegacyContent value)
        {
            return value switch
            {
                ReactionsListForTeamDiscussionCommentLegacyContent.Plus1 => "+1",
                ReactionsListForTeamDiscussionCommentLegacyContent.Minus1 => "-1",
                ReactionsListForTeamDiscussionCommentLegacyContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionCommentLegacyContent.Confused => "confused",
                ReactionsListForTeamDiscussionCommentLegacyContent.Heart => "heart",
                ReactionsListForTeamDiscussionCommentLegacyContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionCommentLegacyContent.Rocket => "rocket",
                ReactionsListForTeamDiscussionCommentLegacyContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForTeamDiscussionCommentLegacyContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForTeamDiscussionCommentLegacyContent.Plus1,
                "-1" => ReactionsListForTeamDiscussionCommentLegacyContent.Minus1,
                "laugh" => ReactionsListForTeamDiscussionCommentLegacyContent.Laugh,
                "confused" => ReactionsListForTeamDiscussionCommentLegacyContent.Confused,
                "heart" => ReactionsListForTeamDiscussionCommentLegacyContent.Heart,
                "hooray" => ReactionsListForTeamDiscussionCommentLegacyContent.Hooray,
                "rocket" => ReactionsListForTeamDiscussionCommentLegacyContent.Rocket,
                "eyes" => ReactionsListForTeamDiscussionCommentLegacyContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}