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
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Confused => "confused",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Eyes => "eyes",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Heart => "heart",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Hooray => "hooray",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Laugh => "laugh",
                ReactionsCreateForTeamDiscussionInOrgRequestContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForTeamDiscussionInOrgRequestContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Plus1,
                "-1" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Minus1,
                "confused" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Confused,
                "eyes" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Eyes,
                "heart" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Heart,
                "hooray" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Hooray,
                "laugh" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Laugh,
                "rocket" => ReactionsCreateForTeamDiscussionInOrgRequestContent.Rocket,
                _ => null,
            };
        }
    }
}