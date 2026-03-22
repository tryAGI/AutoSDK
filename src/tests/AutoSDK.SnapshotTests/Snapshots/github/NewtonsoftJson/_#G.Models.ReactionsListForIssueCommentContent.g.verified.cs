//HintName: G.Models.ReactionsListForIssueCommentContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionsListForIssueCommentContent
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