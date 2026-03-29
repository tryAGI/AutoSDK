//HintName: G.Models.ListAgentsForArchiveOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for agents by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListAgentsForArchiveOrder
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
    public static class ListAgentsForArchiveOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentsForArchiveOrder value)
        {
            return value switch
            {
                ListAgentsForArchiveOrder.Asc => "asc",
                ListAgentsForArchiveOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentsForArchiveOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListAgentsForArchiveOrder.Asc,
                "desc" => ListAgentsForArchiveOrder.Desc,
                _ => null,
            };
        }
    }
}