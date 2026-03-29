//HintName: G.Models.DeleteConversationFlowResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteConversationFlowResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteConversationFlowResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteConversationFlowResponseStatus value)
        {
            return value switch
            {
                DeleteConversationFlowResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteConversationFlowResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteConversationFlowResponseStatus.Error,
                _ => null,
            };
        }
    }
}