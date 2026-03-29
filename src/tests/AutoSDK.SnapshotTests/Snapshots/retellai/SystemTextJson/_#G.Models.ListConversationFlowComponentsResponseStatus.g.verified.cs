//HintName: G.Models.ListConversationFlowComponentsResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListConversationFlowComponentsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowComponentsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowComponentsResponseStatus value)
        {
            return value switch
            {
                ListConversationFlowComponentsResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowComponentsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowComponentsResponseStatus.Error,
                _ => null,
            };
        }
    }
}