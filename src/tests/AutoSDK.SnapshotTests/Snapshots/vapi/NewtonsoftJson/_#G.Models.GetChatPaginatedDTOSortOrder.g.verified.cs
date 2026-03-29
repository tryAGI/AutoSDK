//HintName: G.Models.GetChatPaginatedDTOSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetChatPaginatedDTOSortOrder
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
    public static class GetChatPaginatedDTOSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChatPaginatedDTOSortOrder value)
        {
            return value switch
            {
                GetChatPaginatedDTOSortOrder.Asc => "ASC",
                GetChatPaginatedDTOSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChatPaginatedDTOSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetChatPaginatedDTOSortOrder.Asc,
                "DESC" => GetChatPaginatedDTOSortOrder.Desc,
                _ => null,
            };
        }
    }
}