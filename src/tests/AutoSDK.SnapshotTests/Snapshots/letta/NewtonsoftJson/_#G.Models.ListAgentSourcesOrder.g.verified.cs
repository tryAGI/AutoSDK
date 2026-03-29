//HintName: G.Models.ListAgentSourcesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for sources by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListAgentSourcesOrder
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
    public static class ListAgentSourcesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAgentSourcesOrder value)
        {
            return value switch
            {
                ListAgentSourcesOrder.Asc => "asc",
                ListAgentSourcesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAgentSourcesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListAgentSourcesOrder.Asc,
                "desc" => ListAgentSourcesOrder.Desc,
                _ => null,
            };
        }
    }
}