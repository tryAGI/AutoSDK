//HintName: G.Models.ReactionsListForIssueContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionsListForIssueContent
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
        [global::System.Runtime.Serialization.EnumMember(Value="laugh")]
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="confused")]
        Confused,
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
        [global::System.Runtime.Serialization.EnumMember(Value="rocket")]
        Rocket,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eyes")]
        Eyes,
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
                ReactionsListForIssueContent.Laugh => "laugh",
                ReactionsListForIssueContent.Confused => "confused",
                ReactionsListForIssueContent.Heart => "heart",
                ReactionsListForIssueContent.Hooray => "hooray",
                ReactionsListForIssueContent.Rocket => "rocket",
                ReactionsListForIssueContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForIssueContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForIssueContent.Plus1,
                "-1" => ReactionsListForIssueContent.Minus1,
                "laugh" => ReactionsListForIssueContent.Laugh,
                "confused" => ReactionsListForIssueContent.Confused,
                "heart" => ReactionsListForIssueContent.Heart,
                "hooray" => ReactionsListForIssueContent.Hooray,
                "rocket" => ReactionsListForIssueContent.Rocket,
                "eyes" => ReactionsListForIssueContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}