//HintName: G.Models.GetChatAgentVersionsResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetChatAgentVersionsResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetChatAgentVersionsResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChatAgentVersionsResponseStatus3 value)
        {
            return value switch
            {
                GetChatAgentVersionsResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChatAgentVersionsResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetChatAgentVersionsResponseStatus3.Error,
                _ => null,
            };
        }
    }
}