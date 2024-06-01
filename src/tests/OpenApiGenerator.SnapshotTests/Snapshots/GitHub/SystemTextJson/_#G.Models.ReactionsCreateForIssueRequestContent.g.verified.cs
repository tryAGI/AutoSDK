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
                ReactionsCreateForIssueRequestContent.Laugh => "laugh",
                ReactionsCreateForIssueRequestContent.Confused => "confused",
                ReactionsCreateForIssueRequestContent.Heart => "heart",
                ReactionsCreateForIssueRequestContent.Hooray => "hooray",
                ReactionsCreateForIssueRequestContent.Rocket => "rocket",
                ReactionsCreateForIssueRequestContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForIssueRequestContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForIssueRequestContent.Plus1,
                "-1" => ReactionsCreateForIssueRequestContent.Minus1,
                "laugh" => ReactionsCreateForIssueRequestContent.Laugh,
                "confused" => ReactionsCreateForIssueRequestContent.Confused,
                "heart" => ReactionsCreateForIssueRequestContent.Heart,
                "hooray" => ReactionsCreateForIssueRequestContent.Hooray,
                "rocket" => ReactionsCreateForIssueRequestContent.Rocket,
                "eyes" => ReactionsCreateForIssueRequestContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}