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
                ReactionsListForTeamDiscussionLegacyContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionLegacyContent.Confused => "confused",
                ReactionsListForTeamDiscussionLegacyContent.Heart => "heart",
                ReactionsListForTeamDiscussionLegacyContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionLegacyContent.Rocket => "rocket",
                ReactionsListForTeamDiscussionLegacyContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForTeamDiscussionLegacyContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForTeamDiscussionLegacyContent.Plus1,
                "-1" => ReactionsListForTeamDiscussionLegacyContent.Minus1,
                "laugh" => ReactionsListForTeamDiscussionLegacyContent.Laugh,
                "confused" => ReactionsListForTeamDiscussionLegacyContent.Confused,
                "heart" => ReactionsListForTeamDiscussionLegacyContent.Heart,
                "hooray" => ReactionsListForTeamDiscussionLegacyContent.Hooray,
                "rocket" => ReactionsListForTeamDiscussionLegacyContent.Rocket,
                "eyes" => ReactionsListForTeamDiscussionLegacyContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}