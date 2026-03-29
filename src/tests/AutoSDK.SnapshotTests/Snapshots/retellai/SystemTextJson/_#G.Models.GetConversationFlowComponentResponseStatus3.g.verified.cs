//HintName: G.Models.GetConversationFlowComponentResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConversationFlowComponentResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationFlowComponentResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationFlowComponentResponseStatus3 value)
        {
            return value switch
            {
                GetConversationFlowComponentResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationFlowComponentResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConversationFlowComponentResponseStatus3.Error,
                _ => null,
            };
        }
    }
}