//HintName: G.Models.ListInternalBlocksOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for blocks by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: asc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListInternalBlocksOrder
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
    public static class ListInternalBlocksOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListInternalBlocksOrder value)
        {
            return value switch
            {
                ListInternalBlocksOrder.Asc => "asc",
                ListInternalBlocksOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListInternalBlocksOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListInternalBlocksOrder.Asc,
                "desc" => ListInternalBlocksOrder.Desc,
                _ => null,
            };
        }
    }
}