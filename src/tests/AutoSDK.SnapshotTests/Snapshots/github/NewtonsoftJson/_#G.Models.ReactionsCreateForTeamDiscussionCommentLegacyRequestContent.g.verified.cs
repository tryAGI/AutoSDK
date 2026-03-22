//HintName: G.Models.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionsCreateForTeamDiscussionCommentLegacyRequestContent
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
    public static class ReactionsCreateForTeamDiscussionCommentLegacyRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForTeamDiscussionCommentLegacyRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Plus1 => "+1",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Minus1 => "-1",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Confused => "confused",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Eyes => "eyes",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Heart => "heart",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Hooray => "hooray",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Laugh => "laugh",
                ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForTeamDiscussionCommentLegacyRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Plus1,
                "-1" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Minus1,
                "confused" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Confused,
                "eyes" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Eyes,
                "heart" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Heart,
                "hooray" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Hooray,
                "laugh" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Laugh,
                "rocket" => ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.Rocket,
                _ => null,
            };
        }
    }
}