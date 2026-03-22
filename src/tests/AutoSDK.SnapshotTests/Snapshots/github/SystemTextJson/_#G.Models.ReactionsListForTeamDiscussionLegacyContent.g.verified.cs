//HintName: G.Models.ReactionsListForTeamDiscussionLegacyContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactionsListForTeamDiscussionLegacyContent
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
    public static class ReactionsListForTeamDiscussionLegacyContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForTeamDiscussionLegacyContent value)
        {
            return value switch
            {
                ReactionsListForTeamDiscussionLegacyContent.Plus1 => "+1",
                ReactionsListForTeamDiscussionLegacyContent.Minus1 => "-1",
                ReactionsListForTeamDiscussionLegacyContent.Confused => "confused",
                ReactionsListForTeamDiscussionLegacyContent.Eyes => "eyes",
                ReactionsListForTeamDiscussionLegacyContent.Heart => "heart",
                ReactionsListForTeamDiscussionLegacyContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionLegacyContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionLegacyContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForTeamDiscussionLegacyContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForTeamDiscussionLegacyContent.Plus1,
                "-1" => ReactionsListForTeamDiscussionLegacyContent.Minus1,
                "confused" => ReactionsListForTeamDiscussionLegacyContent.Confused,
                "eyes" => ReactionsListForTeamDiscussionLegacyContent.Eyes,
                "heart" => ReactionsListForTeamDiscussionLegacyContent.Heart,
                "hooray" => ReactionsListForTeamDiscussionLegacyContent.Hooray,
                "laugh" => ReactionsListForTeamDiscussionLegacyContent.Laugh,
                "rocket" => ReactionsListForTeamDiscussionLegacyContent.Rocket,
                _ => null,
            };
        }
    }
}