//HintName: G.Models.ReactionsListForTeamDiscussionInOrgContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactionsListForTeamDiscussionInOrgContent
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
    public static class ReactionsListForTeamDiscussionInOrgContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForTeamDiscussionInOrgContent value)
        {
            return value switch
            {
                ReactionsListForTeamDiscussionInOrgContent.Plus1 => "+1",
                ReactionsListForTeamDiscussionInOrgContent.Minus1 => "-1",
                ReactionsListForTeamDiscussionInOrgContent.Confused => "confused",
                ReactionsListForTeamDiscussionInOrgContent.Eyes => "eyes",
                ReactionsListForTeamDiscussionInOrgContent.Heart => "heart",
                ReactionsListForTeamDiscussionInOrgContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionInOrgContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionInOrgContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForTeamDiscussionInOrgContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForTeamDiscussionInOrgContent.Plus1,
                "-1" => ReactionsListForTeamDiscussionInOrgContent.Minus1,
                "confused" => ReactionsListForTeamDiscussionInOrgContent.Confused,
                "eyes" => ReactionsListForTeamDiscussionInOrgContent.Eyes,
                "heart" => ReactionsListForTeamDiscussionInOrgContent.Heart,
                "hooray" => ReactionsListForTeamDiscussionInOrgContent.Hooray,
                "laugh" => ReactionsListForTeamDiscussionInOrgContent.Laugh,
                "rocket" => ReactionsListForTeamDiscussionInOrgContent.Rocket,
                _ => null,
            };
        }
    }
}