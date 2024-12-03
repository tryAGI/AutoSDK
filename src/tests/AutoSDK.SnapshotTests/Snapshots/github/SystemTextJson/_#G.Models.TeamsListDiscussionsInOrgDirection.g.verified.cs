//HintName: G.Models.TeamsListDiscussionsInOrgDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum TeamsListDiscussionsInOrgDirection
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
    public static class TeamsListDiscussionsInOrgDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsListDiscussionsInOrgDirection value)
        {
            return value switch
            {
                TeamsListDiscussionsInOrgDirection.Asc => "asc",
                TeamsListDiscussionsInOrgDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsListDiscussionsInOrgDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => TeamsListDiscussionsInOrgDirection.Asc,
                "desc" => TeamsListDiscussionsInOrgDirection.Desc,
                _ => null,
            };
        }
    }
}