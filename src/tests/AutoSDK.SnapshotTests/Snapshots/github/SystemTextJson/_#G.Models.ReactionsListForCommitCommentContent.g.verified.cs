//HintName: G.Models.ReactionsListForCommitCommentContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactionsListForCommitCommentContent
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
    public static class ReactionsListForCommitCommentContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForCommitCommentContent value)
        {
            return value switch
            {
                ReactionsListForCommitCommentContent.Plus1 => "+1",
                ReactionsListForCommitCommentContent.Minus1 => "-1",
                ReactionsListForCommitCommentContent.Confused => "confused",
                ReactionsListForCommitCommentContent.Eyes => "eyes",
                ReactionsListForCommitCommentContent.Heart => "heart",
                ReactionsListForCommitCommentContent.Hooray => "hooray",
                ReactionsListForCommitCommentContent.Laugh => "laugh",
                ReactionsListForCommitCommentContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForCommitCommentContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForCommitCommentContent.Plus1,
                "-1" => ReactionsListForCommitCommentContent.Minus1,
                "confused" => ReactionsListForCommitCommentContent.Confused,
                "eyes" => ReactionsListForCommitCommentContent.Eyes,
                "heart" => ReactionsListForCommitCommentContent.Heart,
                "hooray" => ReactionsListForCommitCommentContent.Hooray,
                "laugh" => ReactionsListForCommitCommentContent.Laugh,
                "rocket" => ReactionsListForCommitCommentContent.Rocket,
                _ => null,
            };
        }
    }
}