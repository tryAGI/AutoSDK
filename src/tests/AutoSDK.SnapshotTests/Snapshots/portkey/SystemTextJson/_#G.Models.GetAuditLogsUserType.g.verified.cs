//HintName: G.Models.GetAuditLogsUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAuditLogsUserType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAuditLogsUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuditLogsUserType value)
        {
            return value switch
            {
                GetAuditLogsUserType.ApiKey => "api_key",
                GetAuditLogsUserType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuditLogsUserType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => GetAuditLogsUserType.ApiKey,
                "user" => GetAuditLogsUserType.User,
                _ => null,
            };
        }
    }
}