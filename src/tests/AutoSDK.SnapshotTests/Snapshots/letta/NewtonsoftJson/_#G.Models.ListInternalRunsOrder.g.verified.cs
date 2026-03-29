//HintName: G.Models.ListInternalRunsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for runs by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListInternalRunsOrder
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
    public static class ListInternalRunsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListInternalRunsOrder value)
        {
            return value switch
            {
                ListInternalRunsOrder.Asc => "asc",
                ListInternalRunsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListInternalRunsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListInternalRunsOrder.Asc,
                "desc" => ListInternalRunsOrder.Desc,
                _ => null,
            };
        }
    }
}