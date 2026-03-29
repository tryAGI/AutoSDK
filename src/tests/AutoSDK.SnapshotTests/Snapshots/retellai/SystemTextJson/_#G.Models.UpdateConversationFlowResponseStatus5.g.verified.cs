//HintName: G.Models.UpdateConversationFlowResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateConversationFlowResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConversationFlowResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConversationFlowResponseStatus5 value)
        {
            return value switch
            {
                UpdateConversationFlowResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConversationFlowResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateConversationFlowResponseStatus5.Error,
                _ => null,
            };
        }
    }
}