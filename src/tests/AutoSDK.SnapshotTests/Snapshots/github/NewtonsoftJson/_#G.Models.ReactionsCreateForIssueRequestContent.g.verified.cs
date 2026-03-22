//HintName: G.Models.ReactionsCreateForIssueRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the issue.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionsCreateForIssueRequestContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="+1")]
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="-1")]
        Minus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="confused")]
        Confused,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eyes")]
        Eyes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heart")]
        Heart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hooray")]
        Hooray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="laugh")]
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rocket")]
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