//HintName: G.Models.GetSessionPaginatedDTOSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    public enum GetSessionPaginatedDTOSortOrder
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
    public static class GetSessionPaginatedDTOSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSessionPaginatedDTOSortOrder value)
        {
            return value switch
            {
                GetSessionPaginatedDTOSortOrder.Asc => "ASC",
                GetSessionPaginatedDTOSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSessionPaginatedDTOSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetSessionPaginatedDTOSortOrder.Asc,
                "DESC" => GetSessionPaginatedDTOSortOrder.Desc,
                _ => null,
            };
        }
    }
}