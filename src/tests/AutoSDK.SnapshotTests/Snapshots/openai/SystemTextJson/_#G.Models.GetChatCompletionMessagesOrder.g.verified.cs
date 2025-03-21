//HintName: G.Models.GetChatCompletionMessagesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: asc
    /// </summary>
    public enum GetChatCompletionMessagesOrder
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
    public static class GetChatCompletionMessagesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChatCompletionMessagesOrder value)
        {
            return value switch
            {
                GetChatCompletionMessagesOrder.Asc => "asc",
                GetChatCompletionMessagesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChatCompletionMessagesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => GetChatCompletionMessagesOrder.Asc,
                "desc" => GetChatCompletionMessagesOrder.Desc,
                _ => null,
            };
        }
    }
}