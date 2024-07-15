//HintName: G.Models.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion comment.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionsCreateForTeamDiscussionCommentInOrgRequestContent
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
    public static class ReactionsCreateForTeamDiscussionCommentInOrgRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForTeamDiscussionCommentInOrgRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Plus1 => "+1",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Minus1 => "-1",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Laugh => "laugh",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Confused => "confused",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Heart => "heart",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Hooray => "hooray",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Rocket => "rocket",
                ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForTeamDiscussionCommentInOrgRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Plus1,
                "-1" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Minus1,
                "laugh" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Laugh,
                "confused" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Confused,
                "heart" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Heart,
                "hooray" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Hooray,
                "rocket" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Rocket,
                "eyes" => ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.Eyes,
                _ => null,
            };
        }
    }
}