//HintName: G.Models.ChatCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'chat' for this class.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCostType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCostType value)
        {
            return value switch
            {
                ChatCostType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCostType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ChatCostType.Chat,
                _ => null,
            };
        }
    }
}