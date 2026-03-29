//HintName: G.Models.DeleteConversationFlowComponentResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteConversationFlowComponentResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteConversationFlowComponentResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteConversationFlowComponentResponseStatus3 value)
        {
            return value switch
            {
                DeleteConversationFlowComponentResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteConversationFlowComponentResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteConversationFlowComponentResponseStatus3.Error,
                _ => null,
            };
        }
    }
}