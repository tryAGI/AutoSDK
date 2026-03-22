//HintName: G.Models.ReactionsCreateForIssueRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the issue.
    /// </summary>
    public enum ReactionsCreateForIssueRequestContent
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
    public static class ReactionsCreateForIssueRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForIssueRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForIssueRequestContent.Plus1 => "+1",
                ReactionsCreateForIssueRequestContent.Minus1 => "-1",
                ReactionsCreateForIssueRequestContent.Confused => "confused",
                ReactionsCreateForIssueRequestContent.Eyes => "eyes",
                ReactionsCreateForIssueRequestContent.Heart => "heart",
                ReactionsCreateForIssueRequestContent.Hooray => "hooray",
                ReactionsCreateForIssueRequestContent.Laugh => "laugh",
                ReactionsCreateForIssueRequestContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForIssueRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForIssueRequestContent.Plus1,
                "-1" => ReactionsCreateForIssueRequestContent.Minus1,
                "confused" => ReactionsCreateForIssueRequestContent.Confused,
                "eyes" => ReactionsCreateForIssueRequestContent.Eyes,
                "heart" => ReactionsCreateForIssueRequestContent.Heart,
                "hooray" => ReactionsCreateForIssueRequestContent.Hooray,
                "laugh" => ReactionsCreateForIssueRequestContent.Laugh,
                "rocket" => ReactionsCreateForIssueRequestContent.Rocket,
                _ => null,
            };
        }
    }
}