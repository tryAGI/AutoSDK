//HintName: G.Models.ReactionsCreateForCommitCommentRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the commit comment.
    /// </summary>
    public enum ReactionsCreateForCommitCommentRequestContent
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
    public static class ReactionsCreateForCommitCommentRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForCommitCommentRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForCommitCommentRequestContent.Plus1 => "+1",
                ReactionsCreateForCommitCommentRequestContent.Minus1 => "-1",
                ReactionsCreateForCommitCommentRequestContent.Confused => "confused",
                ReactionsCreateForCommitCommentRequestContent.Eyes => "eyes",
                ReactionsCreateForCommitCommentRequestContent.Heart => "heart",
                ReactionsCreateForCommitCommentRequestContent.Hooray => "hooray",
                ReactionsCreateForCommitCommentRequestContent.Laugh => "laugh",
                ReactionsCreateForCommitCommentRequestContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForCommitCommentRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForCommitCommentRequestContent.Plus1,
                "-1" => ReactionsCreateForCommitCommentRequestContent.Minus1,
                "confused" => ReactionsCreateForCommitCommentRequestContent.Confused,
                "eyes" => ReactionsCreateForCommitCommentRequestContent.Eyes,
                "heart" => ReactionsCreateForCommitCommentRequestContent.Heart,
                "hooray" => ReactionsCreateForCommitCommentRequestContent.Hooray,
                "laugh" => ReactionsCreateForCommitCommentRequestContent.Laugh,
                "rocket" => ReactionsCreateForCommitCommentRequestContent.Rocket,
                _ => null,
            };
        }
    }
}