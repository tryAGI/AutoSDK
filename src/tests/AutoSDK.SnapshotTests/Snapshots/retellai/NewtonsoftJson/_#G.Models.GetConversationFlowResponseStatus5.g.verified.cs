//HintName: G.Models.GetConversationFlowResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConversationFlowResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationFlowResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationFlowResponseStatus5 value)
        {
            return value switch
            {
                GetConversationFlowResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationFlowResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetConversationFlowResponseStatus5.Error,
                _ => null,
            };
        }
    }
}