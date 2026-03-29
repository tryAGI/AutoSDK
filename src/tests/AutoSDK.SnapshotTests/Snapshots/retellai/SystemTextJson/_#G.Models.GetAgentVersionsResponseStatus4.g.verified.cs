//HintName: G.Models.GetAgentVersionsResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAgentVersionsResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAgentVersionsResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAgentVersionsResponseStatus4 value)
        {
            return value switch
            {
                GetAgentVersionsResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAgentVersionsResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetAgentVersionsResponseStatus4.Error,
                _ => null,
            };
        }
    }
}