//HintName: G.Models.SessionControllerFindAllPaginatedSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionControllerFindAllPaginatedSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASC")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DESC")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionControllerFindAllPaginatedSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionControllerFindAllPaginatedSortOrder value)
        {
            return value switch
            {
                SessionControllerFindAllPaginatedSortOrder.Asc => "ASC",
                SessionControllerFindAllPaginatedSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionControllerFindAllPaginatedSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => SessionControllerFindAllPaginatedSortOrder.Asc,
                "DESC" => SessionControllerFindAllPaginatedSortOrder.Desc,
                _ => null,
            };
        }
    }
}