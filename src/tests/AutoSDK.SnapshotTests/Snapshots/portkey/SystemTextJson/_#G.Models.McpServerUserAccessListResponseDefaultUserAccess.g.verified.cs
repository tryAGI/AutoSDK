//HintName: G.Models.McpServerUserAccessListResponseDefaultUserAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum McpServerUserAccessListResponseDefaultUserAccess
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpServerUserAccessListResponseDefaultUserAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpServerUserAccessListResponseDefaultUserAccess value)
        {
            return value switch
            {
                McpServerUserAccessListResponseDefaultUserAccess.Allow => "allow",
                McpServerUserAccessListResponseDefaultUserAccess.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpServerUserAccessListResponseDefaultUserAccess? ToEnum(string value)
        {
            return value switch
            {
                "allow" => McpServerUserAccessListResponseDefaultUserAccess.Allow,
                "deny" => McpServerUserAccessListResponseDefaultUserAccess.Deny,
                _ => null,
            };
        }
    }
}