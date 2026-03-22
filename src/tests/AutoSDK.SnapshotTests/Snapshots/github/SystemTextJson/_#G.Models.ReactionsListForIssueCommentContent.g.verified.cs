//HintName: G.Models.ReactionsListForIssueCommentContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactionsListForIssueCommentContent
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
    public static class ReactionsListForIssueCommentContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForIssueCommentContent value)
        {
            return value switch
            {
                ReactionsListForIssueCommentContent.Plus1 => "+1",
                ReactionsListForIssueCommentContent.Minus1 => "-1",
                ReactionsListForIssueCommentContent.Confused => "confused",
                ReactionsListForIssueCommentContent.Eyes => "eyes",
                ReactionsListForIssueCommentContent.Heart => "heart",
                ReactionsListForIssueCommentContent.Hooray => "hooray",
                ReactionsListForIssueCommentContent.Laugh => "laugh",
                ReactionsListForIssueCommentContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForIssueCommentContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForIssueCommentContent.Plus1,
                "-1" => ReactionsListForIssueCommentContent.Minus1,
                "confused" => ReactionsListForIssueCommentContent.Confused,
                "eyes" => ReactionsListForIssueCommentContent.Eyes,
                "heart" => ReactionsListForIssueCommentContent.Heart,
                "hooray" => ReactionsListForIssueCommentContent.Hooray,
                "laugh" => ReactionsListForIssueCommentContent.Laugh,
                "rocket" => ReactionsListForIssueCommentContent.Rocket,
                _ => null,
            };
        }
    }
}