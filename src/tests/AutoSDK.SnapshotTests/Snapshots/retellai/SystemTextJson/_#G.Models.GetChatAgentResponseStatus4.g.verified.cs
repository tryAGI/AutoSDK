//HintName: G.Models.GetChatAgentResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetChatAgentResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetChatAgentResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChatAgentResponseStatus4 value)
        {
            return value switch
            {
                GetChatAgentResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChatAgentResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetChatAgentResponseStatus4.Error,
                _ => null,
            };
        }
    }
}