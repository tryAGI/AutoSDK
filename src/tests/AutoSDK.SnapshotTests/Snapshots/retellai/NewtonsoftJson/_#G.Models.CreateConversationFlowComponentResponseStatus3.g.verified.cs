//HintName: G.Models.CreateConversationFlowComponentResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateConversationFlowComponentResponseStatus3
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
    public static class CreateConversationFlowComponentResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConversationFlowComponentResponseStatus3 value)
        {
            return value switch
            {
                CreateConversationFlowComponentResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConversationFlowComponentResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateConversationFlowComponentResponseStatus3.Error,
                _ => null,
            };
        }
    }
}