//HintName: G.Models.GetAgentVersionsResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentVersionsResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentVersionsResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentVersionsResponseStatus3 value)
        {
            return value switch
            {
                GetAgentVersionsResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentVersionsResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetAgentVersionsResponseStatus3.Error,
                _ => null,
            };
        }
    }
}