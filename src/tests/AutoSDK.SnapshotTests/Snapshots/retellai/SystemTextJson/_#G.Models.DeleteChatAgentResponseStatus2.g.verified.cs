//HintName: G.Models.DeleteChatAgentResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteChatAgentResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteChatAgentResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteChatAgentResponseStatus2 value)
        {
            return value switch
            {
                DeleteChatAgentResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteChatAgentResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteChatAgentResponseStatus2.Error,
                _ => null,
            };
        }
    }
}