//HintName: G.Models.ListConversationFlowComponentsResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListConversationFlowComponentsResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowComponentsResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowComponentsResponseStatus3 value)
        {
            return value switch
            {
                ListConversationFlowComponentsResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowComponentsResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowComponentsResponseStatus3.Error,
                _ => null,
            };
        }
    }
}