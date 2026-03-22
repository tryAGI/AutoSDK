//HintName: G.Models.ListToolsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: mcp
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListToolsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lambda")]
        Lambda,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListToolsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListToolsType value)
        {
            return value switch
            {
                ListToolsType.Lambda => "lambda",
                ListToolsType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListToolsType? ToEnum(string value)
        {
            return value switch
            {
                "lambda" => ListToolsType.Lambda,
                "mcp" => ListToolsType.Mcp,
                _ => null,
            };
        }
    }
}