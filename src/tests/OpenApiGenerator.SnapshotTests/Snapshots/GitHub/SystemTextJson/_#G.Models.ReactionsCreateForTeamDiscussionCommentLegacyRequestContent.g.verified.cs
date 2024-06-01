//HintName: G.Models.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
    /// </summary>
    public enum ReactionsCreateForTeamDiscussionCommentLegacyRequestContent
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
    public static class ReactionsCreateForTeamDiscussionCommentLegacyRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForTeamDiscussionCommentLegacyRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Plus1 => "+1",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Minus1 => "-1",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Laugh => "laugh",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Confused => "confused",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Heart => "heart",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Hooray => "hooray",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Rocket => "rocket",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForTeamDiscussionCommentLegacyRequestContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Plus1,
                "-1" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Minus1,
                "laugh" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Laugh,
                "confused" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Confused,
                "heart" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Heart,
                "hooray" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Hooray,
                "rocket" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Rocket,
                "eyes" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}