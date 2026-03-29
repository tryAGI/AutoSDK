//HintName: G.Models.GetMCPToolsResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMCPToolsResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMCPToolsResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMCPToolsResponseStatus4 value)
        {
            return value switch
            {
                GetMCPToolsResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMCPToolsResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetMCPToolsResponseStatus4.Error,
                _ => null,
            };
        }
    }
}