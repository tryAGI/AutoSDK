//HintName: G.Models.ChatControllerListChatsSortOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatControllerListChatsSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ASC")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DESC")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatControllerListChatsSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatControllerListChatsSortOrder value)
        {
            return value switch
            {
                ChatControllerListChatsSortOrder.Asc => "ASC",
                ChatControllerListChatsSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatControllerListChatsSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => ChatControllerListChatsSortOrder.Asc,
                "DESC" => ChatControllerListChatsSortOrder.Desc,
                _ => null,
            };
        }
    }
}