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
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Confused => "confused",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Eyes => "eyes",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Heart => "heart",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Hooray => "hooray",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Laugh => "laugh",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForTeamDiscussionCommentLegacyRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Plus1,
                "-1" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Minus1,
                "confused" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Confused,
                "eyes" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Eyes,
                "heart" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Heart,
                "hooray" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Hooray,
                "laugh" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Laugh,
                "rocket" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Rocket,
                _ => null,
            };
        }
    }
}