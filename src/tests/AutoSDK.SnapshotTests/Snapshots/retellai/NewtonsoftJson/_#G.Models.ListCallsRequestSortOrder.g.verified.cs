//HintName: G.Models.ListCallsRequestSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The calls will be sorted by `start_timestamp`, whether to return the calls in ascending or descending order.<br/>
    /// Default Value: descending
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListCallsRequestSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ascending")]
        Ascending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="descending")]
        Descending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCallsRequestSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCallsRequestSortOrder value)
        {
            return value switch
            {
                ListCallsRequestSortOrder.Ascending => "ascending",
                ListCallsRequestSortOrder.Descending => "descending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCallsRequestSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ascending" => ListCallsRequestSortOrder.Ascending,
                "descending" => ListCallsRequestSortOrder.Descending,
                _ => null,
            };
        }
    }
}