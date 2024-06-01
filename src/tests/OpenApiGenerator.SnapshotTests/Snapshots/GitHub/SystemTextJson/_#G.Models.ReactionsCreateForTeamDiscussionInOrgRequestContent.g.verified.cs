//HintName: G.Models.ReactionsCreateForTeamDiscussionInOrgRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion.
    /// </summary>
    public enum ReactionsCreateForTeamDiscussionInOrgRequestContent
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
    public static class ReactionsCreateForTeamDiscussionInOrgRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForTeamDiscussionInOrgRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Plus1 => "+1",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Minus1 => "-1",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Laugh => "laugh",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Confused => "confused",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Heart => "heart",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Hooray => "hooray",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Rocket => "rocket",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForTeamDiscussionInOrgRequestContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Plus1,
                "-1" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Minus1,
                "laugh" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Laugh,
                "confused" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Confused,
                "heart" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Heart,
                "hooray" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Hooray,
                "rocket" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Rocket,
                "eyes" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}