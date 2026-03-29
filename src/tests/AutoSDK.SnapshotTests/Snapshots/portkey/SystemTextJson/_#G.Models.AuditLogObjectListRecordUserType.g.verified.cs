//HintName: G.Models.AuditLogObjectListRecordUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of user who made the request
    /// </summary>
    public enum AuditLogObjectListRecordUserType
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
    public static class AuditLogObjectListRecordUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogObjectListRecordUserType value)
        {
            return value switch
            {
                AuditLogObjectListRecordUserType.ApiKey => "api_key",
                AuditLogObjectListRecordUserType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogObjectListRecordUserType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => AuditLogObjectListRecordUserType.ApiKey,
                "user" => AuditLogObjectListRecordUserType.User,
                _ => null,
            };
        }
    }
}