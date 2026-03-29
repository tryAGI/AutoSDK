//HintName: G.Models.ListConversationFlowsResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListConversationFlowsResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowsResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowsResponseStatus3 value)
        {
            return value switch
            {
                ListConversationFlowsResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowsResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowsResponseStatus3.Error,
                _ => null,
            };
        }
    }
}