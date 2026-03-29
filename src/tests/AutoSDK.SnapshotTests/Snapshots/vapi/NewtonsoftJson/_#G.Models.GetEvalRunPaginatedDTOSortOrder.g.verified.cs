//HintName: G.Models.GetEvalRunPaginatedDTOSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetEvalRunPaginatedDTOSortOrder
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
    public static class GetEvalRunPaginatedDTOSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalRunPaginatedDTOSortOrder value)
        {
            return value switch
            {
                GetEvalRunPaginatedDTOSortOrder.Asc => "ASC",
                GetEvalRunPaginatedDTOSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalRunPaginatedDTOSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetEvalRunPaginatedDTOSortOrder.Asc,
                "DESC" => GetEvalRunPaginatedDTOSortOrder.Desc,
                _ => null,
            };
        }
    }
}