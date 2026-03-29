//HintName: G.Models.UpdateChatAgentResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateChatAgentResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateChatAgentResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateChatAgentResponseStatus value)
        {
            return value switch
            {
                UpdateChatAgentResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChatAgentResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdateChatAgentResponseStatus.Error,
                _ => null,
            };
        }
    }
}