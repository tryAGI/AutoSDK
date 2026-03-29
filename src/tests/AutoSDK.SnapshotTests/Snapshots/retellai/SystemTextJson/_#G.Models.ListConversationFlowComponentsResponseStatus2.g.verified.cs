//HintName: G.Models.ListConversationFlowComponentsResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListConversationFlowComponentsResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowComponentsResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowComponentsResponseStatus2 value)
        {
            return value switch
            {
                ListConversationFlowComponentsResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowComponentsResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowComponentsResponseStatus2.Error,
                _ => null,
            };
        }
    }
}