//HintName: G.Models.BulkUpdateMcpServerUserAccessDefaultUserAccess.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Server default when user has no explicit override
    /// </summary>
    public enum BulkUpdateMcpServerUserAccessDefaultUserAccess
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
    public static class BulkUpdateMcpServerUserAccessDefaultUserAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkUpdateMcpServerUserAccessDefaultUserAccess value)
        {
            return value switch
            {
                BulkUpdateMcpServerUserAccessDefaultUserAccess.Allow => "allow",
                BulkUpdateMcpServerUserAccessDefaultUserAccess.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkUpdateMcpServerUserAccessDefaultUserAccess? ToEnum(string value)
        {
            return value switch
            {
                "allow" => BulkUpdateMcpServerUserAccessDefaultUserAccess.Allow,
                "deny" => BulkUpdateMcpServerUserAccessDefaultUserAccess.Deny,
                _ => null,
            };
        }
    }
}