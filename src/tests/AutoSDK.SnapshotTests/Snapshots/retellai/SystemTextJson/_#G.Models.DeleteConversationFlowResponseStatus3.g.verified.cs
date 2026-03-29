//HintName: G.Models.DeleteConversationFlowResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteConversationFlowResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteConversationFlowResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteConversationFlowResponseStatus3 value)
        {
            return value switch
            {
                DeleteConversationFlowResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteConversationFlowResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteConversationFlowResponseStatus3.Error,
                _ => null,
            };
        }
    }
}