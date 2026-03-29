//HintName: G.Models.DeleteConversationFlowResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteConversationFlowResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteConversationFlowResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteConversationFlowResponseStatus4 value)
        {
            return value switch
            {
                DeleteConversationFlowResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteConversationFlowResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteConversationFlowResponseStatus4.Error,
                _ => null,
            };
        }
    }
}