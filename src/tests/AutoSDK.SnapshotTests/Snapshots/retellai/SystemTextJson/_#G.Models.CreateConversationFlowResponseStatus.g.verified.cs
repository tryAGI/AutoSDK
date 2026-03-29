//HintName: G.Models.CreateConversationFlowResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateConversationFlowResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateConversationFlowResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConversationFlowResponseStatus value)
        {
            return value switch
            {
                CreateConversationFlowResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConversationFlowResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateConversationFlowResponseStatus.Error,
                _ => null,
            };
        }
    }
}