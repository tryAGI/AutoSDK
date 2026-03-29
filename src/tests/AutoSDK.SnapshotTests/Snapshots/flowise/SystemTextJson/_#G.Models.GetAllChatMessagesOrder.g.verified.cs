//HintName: G.Models.GetAllChatMessagesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAllChatMessagesOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAllChatMessagesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAllChatMessagesOrder value)
        {
            return value switch
            {
                GetAllChatMessagesOrder.Asc => "ASC",
                GetAllChatMessagesOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAllChatMessagesOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetAllChatMessagesOrder.Asc,
                "DESC" => GetAllChatMessagesOrder.Desc,
                _ => null,
            };
        }
    }
}