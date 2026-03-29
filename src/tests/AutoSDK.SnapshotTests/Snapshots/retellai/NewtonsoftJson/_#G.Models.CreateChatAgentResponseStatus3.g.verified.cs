//HintName: G.Models.CreateChatAgentResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChatAgentResponseStatus3
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
    public static class CreateChatAgentResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatAgentResponseStatus3 value)
        {
            return value switch
            {
                CreateChatAgentResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatAgentResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateChatAgentResponseStatus3.Error,
                _ => null,
            };
        }
    }
}