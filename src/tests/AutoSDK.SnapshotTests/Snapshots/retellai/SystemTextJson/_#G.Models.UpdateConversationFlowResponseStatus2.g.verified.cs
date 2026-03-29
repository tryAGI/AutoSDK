//HintName: G.Models.UpdateConversationFlowResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateConversationFlowResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConversationFlowResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConversationFlowResponseStatus2 value)
        {
            return value switch
            {
                UpdateConversationFlowResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConversationFlowResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateConversationFlowResponseStatus2.Error,
                _ => null,
            };
        }
    }
}