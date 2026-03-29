//HintName: G.Models.GetAgentVersionsResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentVersionsResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentVersionsResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentVersionsResponseStatus2 value)
        {
            return value switch
            {
                GetAgentVersionsResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentVersionsResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetAgentVersionsResponseStatus2.Error,
                _ => null,
            };
        }
    }
}