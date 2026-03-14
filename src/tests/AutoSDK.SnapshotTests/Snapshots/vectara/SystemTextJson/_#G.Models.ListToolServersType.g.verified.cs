//HintName: G.Models.ListToolServersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: mcp
    /// </summary>
    public enum ListToolServersType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListToolServersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListToolServersType value)
        {
            return value switch
            {
                ListToolServersType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListToolServersType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => ListToolServersType.Mcp,
                _ => null,
            };
        }
    }
}