//HintName: G.Models.DeleteConversationFlowComponentResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteConversationFlowComponentResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteConversationFlowComponentResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteConversationFlowComponentResponseStatus value)
        {
            return value switch
            {
                DeleteConversationFlowComponentResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteConversationFlowComponentResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteConversationFlowComponentResponseStatus.Error,
                _ => null,
            };
        }
    }
}