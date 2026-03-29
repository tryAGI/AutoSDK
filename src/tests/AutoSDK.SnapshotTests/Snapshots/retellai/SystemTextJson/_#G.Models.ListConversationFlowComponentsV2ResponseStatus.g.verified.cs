//HintName: G.Models.ListConversationFlowComponentsV2ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListConversationFlowComponentsV2ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationFlowComponentsV2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationFlowComponentsV2ResponseStatus value)
        {
            return value switch
            {
                ListConversationFlowComponentsV2ResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationFlowComponentsV2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListConversationFlowComponentsV2ResponseStatus.Error,
                _ => null,
            };
        }
    }
}