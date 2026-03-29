//HintName: G.Models.ScorecardControllerGetPaginatedSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScorecardControllerGetPaginatedSortOrder
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
    public static class ScorecardControllerGetPaginatedSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScorecardControllerGetPaginatedSortOrder value)
        {
            return value switch
            {
                ScorecardControllerGetPaginatedSortOrder.Asc => "ASC",
                ScorecardControllerGetPaginatedSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScorecardControllerGetPaginatedSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ScorecardControllerGetPaginatedSortOrder.Asc,
                "DESC" => ScorecardControllerGetPaginatedSortOrder.Desc,
                _ => null,
            };
        }
    }
}