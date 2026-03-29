//HintName: G.Models.ServerToolUseContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: server_tool_use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerToolUseContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_tool_use")]
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerToolUseContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerToolUseContentType value)
        {
            return value switch
            {
                ServerToolUseContentType.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerToolUseContentType? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => ServerToolUseContentType.ServerToolUse,
                _ => null,
            };
        }
    }
}