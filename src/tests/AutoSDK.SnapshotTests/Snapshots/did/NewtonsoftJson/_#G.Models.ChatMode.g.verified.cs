//HintName: G.Models.ChatMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMode
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
    public static class ChatModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMode value)
        {
            return value switch
            {
                ChatMode.Functional => "Functional",
                ChatMode.Maintenance => "Maintenance",
                ChatMode.Playground => "Playground",
                ChatMode.TextOnly => "TextOnly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMode? ToEnum(string value)
        {
            return value switch
            {
                "Functional" => ChatMode.Functional,
                "Maintenance" => ChatMode.Maintenance,
                "Playground" => ChatMode.Playground,
                "TextOnly" => ChatMode.TextOnly,
                _ => null,
            };
        }
    }
}