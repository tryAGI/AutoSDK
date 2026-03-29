//HintName: G.Models.ChatflowType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatflowType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHATFLOW")]
        Chatflow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MULTIAGENT")]
        Multiagent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatflowTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatflowType value)
        {
            return value switch
            {
                ChatflowType.Chatflow => "CHATFLOW",
                ChatflowType.Multiagent => "MULTIAGENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatflowType? ToEnum(string value)
        {
            return value switch
            {
                "CHATFLOW" => ChatflowType.Chatflow,
                "MULTIAGENT" => ChatflowType.Multiagent,
                _ => null,
            };
        }
    }
}