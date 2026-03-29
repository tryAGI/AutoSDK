//HintName: G.Models.EvalUserEditableType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the eval.<br/>
    /// Currently it is fixed to `chat.mockConversation`.<br/>
    /// Example: chat.mockConversation
    /// </summary>
    public enum EvalUserEditableType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatMockConversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalUserEditableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalUserEditableType value)
        {
            return value switch
            {
                EvalUserEditableType.ChatMockConversation => "chat.mockConversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalUserEditableType? ToEnum(string value)
        {
            return value switch
            {
                "chat.mockConversation" => EvalUserEditableType.ChatMockConversation,
                _ => null,
            };
        }
    }
}