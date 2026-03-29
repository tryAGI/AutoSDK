//HintName: G.Models.GetConversationFlowResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConversationFlowResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationFlowResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationFlowResponseStatus2 value)
        {
            return value switch
            {
                GetConversationFlowResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationFlowResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConversationFlowResponseStatus2.Error,
                _ => null,
            };
        }
    }
}