//HintName: G.Models.UpdateConversationFlowResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateConversationFlowResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateConversationFlowResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConversationFlowResponseStatus3 value)
        {
            return value switch
            {
                UpdateConversationFlowResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConversationFlowResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateConversationFlowResponseStatus3.Error,
                _ => null,
            };
        }
    }
}