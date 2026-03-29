//HintName: G.Models.EvalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the eval.<br/>
    /// Currently it is fixed to `chat.mockConversation`.<br/>
    /// Example: chat.mockConversation
    /// </summary>
    public enum EvalType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatMockConversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalType value)
        {
            return value switch
            {
                EvalType.ChatMockConversation => "chat.mockConversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalType? ToEnum(string value)
        {
            return value switch
            {
                "chat.mockConversation" => EvalType.ChatMockConversation,
                _ => null,
            };
        }
    }
}