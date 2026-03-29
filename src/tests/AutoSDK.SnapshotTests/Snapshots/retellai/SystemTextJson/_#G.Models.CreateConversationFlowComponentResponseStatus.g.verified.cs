//HintName: G.Models.CreateConversationFlowComponentResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConversationFlowComponentResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConversationFlowComponentResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConversationFlowComponentResponseStatus value)
        {
            return value switch
            {
                CreateConversationFlowComponentResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConversationFlowComponentResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateConversationFlowComponentResponseStatus.Error,
                _ => null,
            };
        }
    }
}