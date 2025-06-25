//HintName: G.Models.TeamsListDiscussionCommentsLegacyDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum TeamsListDiscussionCommentsLegacyDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsListDiscussionCommentsLegacyDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsListDiscussionCommentsLegacyDirection value)
        {
            return value switch
            {
                TeamsListDiscussionCommentsLegacyDirection.Asc => "asc",
                TeamsListDiscussionCommentsLegacyDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsListDiscussionCommentsLegacyDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => TeamsListDiscussionCommentsLegacyDirection.Asc,
                "desc" => TeamsListDiscussionCommentsLegacyDirection.Desc,
                _ => null,
            };
        }
    }
}