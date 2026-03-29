//HintName: G.Models.SearchRequestLogsRequestSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort direction. Must be provided together with sort_by.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchRequestLogsRequestSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestLogsRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestLogsRequestSortOrder value)
        {
            return value switch
            {
                SearchRequestLogsRequestSortOrder.Asc => "asc",
                SearchRequestLogsRequestSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestLogsRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SearchRequestLogsRequestSortOrder.Asc,
                "desc" => SearchRequestLogsRequestSortOrder.Desc,
                _ => null,
            };
        }
    }
}