//HintName: G.Models.McpServerUserAccessItemConnectionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpServerUserAccessItemConnectionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Connected,
        /// <summary>
        /// 
        /// </summary>
        NotConnected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerUserAccessItemConnectionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerUserAccessItemConnectionStatus value)
        {
            return value switch
            {
                McpServerUserAccessItemConnectionStatus.Connected => "connected",
                McpServerUserAccessItemConnectionStatus.NotConnected => "not_connected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerUserAccessItemConnectionStatus? ToEnum(string value)
        {
            return value switch
            {
                "connected" => McpServerUserAccessItemConnectionStatus.Connected,
                "not_connected" => McpServerUserAccessItemConnectionStatus.NotConnected,
                _ => null,
            };
        }
    }
}