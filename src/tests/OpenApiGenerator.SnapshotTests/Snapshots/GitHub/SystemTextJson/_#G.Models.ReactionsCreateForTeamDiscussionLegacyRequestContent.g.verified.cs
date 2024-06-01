//HintName: G.Models.ReactionsCreateForTeamDiscussionLegacyRequestContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the team discussion.
    /// </summary>
    public enum ReactionsCreateForTeamDiscussionLegacyRequestContent
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
    public static class ReactionsCreateForTeamDiscussionLegacyRequestContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsCreateForTeamDiscussionLegacyRequestContent value)
        {
            return value switch
            {
                ReactionsCreateForTeamDiscussionLegacyRequestContent.Plus1 => "+1",
                ReactionsCreateForTeamDiscussionLegacyRequestContent.Minus1 => "-1",
                ReactionsCreateForTeamDiscussionLegacyRequestContent.Laugh => "laugh",
                ReactionsCreateForTeamDiscussionLegacyRequestContent.Confused => "confused",
                ReactionsCreateForTeamDiscussionLegacyRequestContent.Heart => "heart",
                ReactionsCreateForTeamDiscussionLegacyRequestContent.Hooray => "hooray",
                ReactionsCreateForTeamDiscussionLegacyRequestContent.Rocket => "rocket",
                ReactionsCreateForTeamDiscussionLegacyRequestContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsCreateForTeamDiscussionLegacyRequestContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsCreateForTeamDiscussionLegacyRequestContent.Plus1,
                "-1" => ReactionsCreateForTeamDiscussionLegacyRequestContent.Minus1,
                "laugh" => ReactionsCreateForTeamDiscussionLegacyRequestContent.Laugh,
                "confused" => ReactionsCreateForTeamDiscussionLegacyRequestContent.Confused,
                "heart" => ReactionsCreateForTeamDiscussionLegacyRequestContent.Heart,
                "hooray" => ReactionsCreateForTeamDiscussionLegacyRequestContent.Hooray,
                "rocket" => ReactionsCreateForTeamDiscussionLegacyRequestContent.Rocket,
                "eyes" => ReactionsCreateForTeamDiscussionLegacyRequestContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}