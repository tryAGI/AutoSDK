//HintName: G.Models.ListProjectSessionsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order by ID: 'asc' (ascending) or 'desc' (descending).<br/>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListProjectSessionsOrder
    {
        /// <summary>
        /// 'asc' (ascending) or 'desc' (descending).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 'asc' (ascending) or 'desc' (descending).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListProjectSessionsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectSessionsOrder value)
        {
            return value switch
            {
                ListProjectSessionsOrder.Asc => "asc",
                ListProjectSessionsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectSessionsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProjectSessionsOrder.Asc,
                "desc" => ListProjectSessionsOrder.Desc,
                _ => null,
            };
        }
    }
}