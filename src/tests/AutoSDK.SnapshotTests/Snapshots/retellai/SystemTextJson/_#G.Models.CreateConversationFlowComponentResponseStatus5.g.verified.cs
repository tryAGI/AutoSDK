//HintName: G.Models.CreateConversationFlowComponentResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConversationFlowComponentResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConversationFlowComponentResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConversationFlowComponentResponseStatus5 value)
        {
            return value switch
            {
                CreateConversationFlowComponentResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConversationFlowComponentResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateConversationFlowComponentResponseStatus5.Error,
                _ => null,
            };
        }
    }
}