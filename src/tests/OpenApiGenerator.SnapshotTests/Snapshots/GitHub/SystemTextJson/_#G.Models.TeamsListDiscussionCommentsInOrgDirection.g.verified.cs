//HintName: G.Models.TeamsListDiscussionCommentsInOrgDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum TeamsListDiscussionCommentsInOrgDirection
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
    public static class TeamsListDiscussionCommentsInOrgDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsListDiscussionCommentsInOrgDirection value)
        {
            return value switch
            {
                TeamsListDiscussionCommentsInOrgDirection.Asc => "asc",
                TeamsListDiscussionCommentsInOrgDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsListDiscussionCommentsInOrgDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => TeamsListDiscussionCommentsInOrgDirection.Asc,
                "desc" => TeamsListDiscussionCommentsInOrgDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}