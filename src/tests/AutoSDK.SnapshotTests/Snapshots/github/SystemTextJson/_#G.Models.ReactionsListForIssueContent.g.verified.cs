//HintName: G.Models.ReactionsListForIssueContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactionsListForIssueContent
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
    public static class ReactionsListForIssueContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForIssueContent value)
        {
            return value switch
            {
                ReactionsListForIssueContent.Plus1 => "+1",
                ReactionsListForIssueContent.Minus1 => "-1",
                ReactionsListForIssueContent.Confused => "confused",
                ReactionsListForIssueContent.Eyes => "eyes",
                ReactionsListForIssueContent.Heart => "heart",
                ReactionsListForIssueContent.Hooray => "hooray",
                ReactionsListForIssueContent.Laugh => "laugh",
                ReactionsListForIssueContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForIssueContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForIssueContent.Plus1,
                "-1" => ReactionsListForIssueContent.Minus1,
                "confused" => ReactionsListForIssueContent.Confused,
                "eyes" => ReactionsListForIssueContent.Eyes,
                "heart" => ReactionsListForIssueContent.Heart,
                "hooray" => ReactionsListForIssueContent.Hooray,
                "laugh" => ReactionsListForIssueContent.Laugh,
                "rocket" => ReactionsListForIssueContent.Rocket,
                _ => null,
            };
        }
    }
}