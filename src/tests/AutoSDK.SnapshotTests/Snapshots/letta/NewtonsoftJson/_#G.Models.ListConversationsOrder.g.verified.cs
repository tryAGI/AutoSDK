//HintName: G.Models.ListConversationsOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for conversations. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListConversationsOrder
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
    public static class ListConversationsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationsOrder value)
        {
            return value switch
            {
                ListConversationsOrder.Asc => "asc",
                ListConversationsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListConversationsOrder.Asc,
                "desc" => ListConversationsOrder.Desc,
                _ => null,
            };
        }
    }
}