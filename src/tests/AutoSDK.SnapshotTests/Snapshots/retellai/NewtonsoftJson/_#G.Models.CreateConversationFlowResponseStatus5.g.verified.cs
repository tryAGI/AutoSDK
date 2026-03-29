//HintName: G.Models.CreateConversationFlowResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateConversationFlowResponseStatus5
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
    public static class CreateConversationFlowResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConversationFlowResponseStatus5 value)
        {
            return value switch
            {
                CreateConversationFlowResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConversationFlowResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateConversationFlowResponseStatus5.Error,
                _ => null,
            };
        }
    }
}