//HintName: G.Models.ListConversationMessagesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sort order for messages by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListConversationMessagesOrder
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
    public static class ListConversationMessagesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationMessagesOrder value)
        {
            return value switch
            {
                ListConversationMessagesOrder.Asc => "asc",
                ListConversationMessagesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationMessagesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListConversationMessagesOrder.Asc,
                "desc" => ListConversationMessagesOrder.Desc,
                _ => null,
            };
        }
    }
}