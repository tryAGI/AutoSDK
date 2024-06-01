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
                ReactionsListForTeamDiscussionInOrgContent.Laugh => "laugh",
                ReactionsListForTeamDiscussionInOrgContent.Confused => "confused",
                ReactionsListForTeamDiscussionInOrgContent.Heart => "heart",
                ReactionsListForTeamDiscussionInOrgContent.Hooray => "hooray",
                ReactionsListForTeamDiscussionInOrgContent.Rocket => "rocket",
                ReactionsListForTeamDiscussionInOrgContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForTeamDiscussionInOrgContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForTeamDiscussionInOrgContent.Plus1,
                "-1" => ReactionsListForTeamDiscussionInOrgContent.Minus1,
                "laugh" => ReactionsListForTeamDiscussionInOrgContent.Laugh,
                "confused" => ReactionsListForTeamDiscussionInOrgContent.Confused,
                "heart" => ReactionsListForTeamDiscussionInOrgContent.Heart,
                "hooray" => ReactionsListForTeamDiscussionInOrgContent.Hooray,
                "rocket" => ReactionsListForTeamDiscussionInOrgContent.Rocket,
                "eyes" => ReactionsListForTeamDiscussionInOrgContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}