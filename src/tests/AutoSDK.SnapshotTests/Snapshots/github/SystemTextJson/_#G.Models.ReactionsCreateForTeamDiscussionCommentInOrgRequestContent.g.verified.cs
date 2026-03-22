//HintName: G.Models.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
    /// </summary>
    public enum ReactionsCreateForTeamDiscussionCommentInOrgRequestContent
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
    public static class ReactionsCreateForTeamDiscussionCommentInOrgRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForTeamDiscussionCommentInOrgRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Plus1 => "+1",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Minus1 => "-1",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Confused => "confused",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Eyes => "eyes",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Heart => "heart",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Hooray => "hooray",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Laugh => "laugh",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForTeamDiscussionCommentInOrgRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Plus1,
                "-1" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Minus1,
                "confused" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Confused,
                "eyes" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Eyes,
                "heart" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Heart,
                "hooray" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Hooray,
                "laugh" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Laugh,
                "rocket" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Rocket,
                _ => null,
            };
        }
    }
}