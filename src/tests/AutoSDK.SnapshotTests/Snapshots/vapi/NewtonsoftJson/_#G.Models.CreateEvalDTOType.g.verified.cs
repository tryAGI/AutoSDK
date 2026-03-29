//HintName: G.Models.CreateEvalDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the eval.<br/>
    /// Currently it is fixed to `chat.mockConversation`.<br/>
    /// Example: chat.mockConversation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvalDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat.mockConversation")]
        ChatMockConversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEvalDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalDTOType value)
        {
            return value switch
            {
                CreateEvalDTOType.ChatMockConversation => "chat.mockConversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalDTOType? ToEnum(string value)
        {
            return value switch
            {
                "chat.mockConversation" => CreateEvalDTOType.ChatMockConversation,
                _ => null,
            };
        }
    }
}