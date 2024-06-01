//HintName: G.Models.ReactionsCreateForIssueCommentRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the issue comment.
    /// </summary>
    public enum ReactionsCreateForIssueCommentRequestContent
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
    public static class ReactionsCreateForIssueCommentRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForIssueCommentRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForIssueCommentRequestContent.Plus1 => "+1",
                ReactionsCreateForIssueCommentRequestContent.Minus1 => "-1",
                ReactionsCreateForIssueCommentRequestContent.Laugh => "laugh",
                ReactionsCreateForIssueCommentRequestContent.Confused => "confused",
                ReactionsCreateForIssueCommentRequestContent.Heart => "heart",
                ReactionsCreateForIssueCommentRequestContent.Hooray => "hooray",
                ReactionsCreateForIssueCommentRequestContent.Rocket => "rocket",
                ReactionsCreateForIssueCommentRequestContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForIssueCommentRequestContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForIssueCommentRequestContent.Plus1,
                "-1" => ReactionsCreateForIssueCommentRequestContent.Minus1,
                "laugh" => ReactionsCreateForIssueCommentRequestContent.Laugh,
                "confused" => ReactionsCreateForIssueCommentRequestContent.Confused,
                "heart" => ReactionsCreateForIssueCommentRequestContent.Heart,
                "hooray" => ReactionsCreateForIssueCommentRequestContent.Hooray,
                "rocket" => ReactionsCreateForIssueCommentRequestContent.Rocket,
                "eyes" => ReactionsCreateForIssueCommentRequestContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}