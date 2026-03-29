//HintName: G.Models.PublishAgentResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PublishAgentResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishAgentResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishAgentResponseStatus2 value)
        {
            return value switch
            {
                PublishAgentResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishAgentResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => PublishAgentResponseStatus2.Error,
                _ => null,
            };
        }
    }
}