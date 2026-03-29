//HintName: G.Models.UpdateConversationFlowComponentResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateConversationFlowComponentResponseStatus
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
    public static class UpdateConversationFlowComponentResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConversationFlowComponentResponseStatus value)
        {
            return value switch
            {
                UpdateConversationFlowComponentResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConversationFlowComponentResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateConversationFlowComponentResponseStatus.Error,
                _ => null,
            };
        }
    }
}