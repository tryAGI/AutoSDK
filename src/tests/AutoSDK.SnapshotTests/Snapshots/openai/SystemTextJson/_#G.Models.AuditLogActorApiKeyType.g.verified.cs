//HintName: G.Models.AuditLogActorApiKeyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of API key. Can be either `user` or `service_account`.
    /// </summary>
    public enum AuditLogActorApiKeyType
    {
        /// <summary>
        /// 
        /// </summary>
        ServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogActorApiKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogActorApiKeyType value)
        {
            return value switch
            {
                AuditLogActorApiKeyType.ServiceAccount => "service_account",
                AuditLogActorApiKeyType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogActorApiKeyType? ToEnum(string value)
        {
            return value switch
            {
                "service_account" => AuditLogActorApiKeyType.ServiceAccount,
                "user" => AuditLogActorApiKeyType.User,
                _ => null,
            };
        }
    }
}