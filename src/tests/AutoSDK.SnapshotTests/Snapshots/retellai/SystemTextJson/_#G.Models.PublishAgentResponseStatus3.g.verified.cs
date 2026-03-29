//HintName: G.Models.PublishAgentResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublishAgentResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishAgentResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishAgentResponseStatus3 value)
        {
            return value switch
            {
                PublishAgentResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishAgentResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => PublishAgentResponseStatus3.Error,
                _ => null,
            };
        }
    }
}