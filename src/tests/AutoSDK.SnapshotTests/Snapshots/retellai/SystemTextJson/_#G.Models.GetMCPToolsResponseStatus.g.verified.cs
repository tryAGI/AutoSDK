//HintName: G.Models.GetMCPToolsResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetMCPToolsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMCPToolsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMCPToolsResponseStatus value)
        {
            return value switch
            {
                GetMCPToolsResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMCPToolsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetMCPToolsResponseStatus.Error,
                _ => null,
            };
        }
    }
}