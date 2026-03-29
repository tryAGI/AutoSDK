//HintName: G.Models.ListBlocksForIdentityOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for blocks by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListBlocksForIdentityOrder
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
    public static class ListBlocksForIdentityOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBlocksForIdentityOrder value)
        {
            return value switch
            {
                ListBlocksForIdentityOrder.Asc => "asc",
                ListBlocksForIdentityOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBlocksForIdentityOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListBlocksForIdentityOrder.Asc,
                "desc" => ListBlocksForIdentityOrder.Desc,
                _ => null,
            };
        }
    }
}