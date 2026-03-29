//HintName: G.Models.UpdateConversationFlowComponentResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateConversationFlowComponentResponseStatus3
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
    public static class UpdateConversationFlowComponentResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConversationFlowComponentResponseStatus3 value)
        {
            return value switch
            {
                UpdateConversationFlowComponentResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConversationFlowComponentResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateConversationFlowComponentResponseStatus3.Error,
                _ => null,
            };
        }
    }
}