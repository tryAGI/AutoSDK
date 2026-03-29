//HintName: G.Models.IChatPayloadChatMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IChatPayloadChatMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Functional")]
        Functional,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Maintenance")]
        Maintenance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Playground")]
        Playground,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TextOnly")]
        TextOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IChatPayloadChatModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IChatPayloadChatMode value)
        {
            return value switch
            {
                IChatPayloadChatMode.Functional => "Functional",
                IChatPayloadChatMode.Maintenance => "Maintenance",
                IChatPayloadChatMode.Playground => "Playground",
                IChatPayloadChatMode.TextOnly => "TextOnly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IChatPayloadChatMode? ToEnum(string value)
        {
            return value switch
            {
                "Functional" => IChatPayloadChatMode.Functional,
                "Maintenance" => IChatPayloadChatMode.Maintenance,
                "Playground" => IChatPayloadChatMode.Playground,
                "TextOnly" => IChatPayloadChatMode.TextOnly,
                _ => null,
            };
        }
    }
}