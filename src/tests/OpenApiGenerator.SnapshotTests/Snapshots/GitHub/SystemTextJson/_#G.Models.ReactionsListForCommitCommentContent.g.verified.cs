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
                ReactionsListForCommitCommentContent.Laugh => "laugh",
                ReactionsListForCommitCommentContent.Confused => "confused",
                ReactionsListForCommitCommentContent.Heart => "heart",
                ReactionsListForCommitCommentContent.Hooray => "hooray",
                ReactionsListForCommitCommentContent.Rocket => "rocket",
                ReactionsListForCommitCommentContent.Eyes => "eyes",
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
                "laugh" => ReactionsListForCommitCommentContent.Laugh,
                "confused" => ReactionsListForCommitCommentContent.Confused,
                "heart" => ReactionsListForCommitCommentContent.Heart,
                "hooray" => ReactionsListForCommitCommentContent.Hooray,
                "rocket" => ReactionsListForCommitCommentContent.Rocket,
                "eyes" => ReactionsListForCommitCommentContent.Eyes,
                _ => null,
            };
        }
    }
}