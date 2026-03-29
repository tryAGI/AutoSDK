//HintName: G.Models.GetMCPToolsResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMCPToolsResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMCPToolsResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMCPToolsResponseStatus2 value)
        {
            return value switch
            {
                GetMCPToolsResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMCPToolsResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetMCPToolsResponseStatus2.Error,
                _ => null,
            };
        }
    }
}