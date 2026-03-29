//HintName: G.Models.ListToolsForAgentOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for tools by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListToolsForAgentOrder
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
    public static class ListToolsForAgentOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListToolsForAgentOrder value)
        {
            return value switch
            {
                ListToolsForAgentOrder.Asc => "asc",
                ListToolsForAgentOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListToolsForAgentOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListToolsForAgentOrder.Asc,
                "desc" => ListToolsForAgentOrder.Desc,
                _ => null,
            };
        }
    }
}