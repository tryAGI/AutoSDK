//HintName: G.Models.GetConversationFlowComponentResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConversationFlowComponentResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationFlowComponentResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationFlowComponentResponseStatus value)
        {
            return value switch
            {
                GetConversationFlowComponentResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationFlowComponentResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConversationFlowComponentResponseStatus.Error,
                _ => null,
            };
        }
    }
}