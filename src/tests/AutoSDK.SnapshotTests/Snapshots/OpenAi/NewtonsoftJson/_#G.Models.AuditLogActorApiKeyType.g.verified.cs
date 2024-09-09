//HintName: G.Models.AuditLogActorApiKeyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of API key. Can be either `user` or `service_account`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuditLogActorApiKeyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="service_account")]
        ServiceAccount,
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
                AuditLogActorApiKeyType.User => "user",
                AuditLogActorApiKeyType.ServiceAccount => "service_account",
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
                "user" => AuditLogActorApiKeyType.User,
                "service_account" => AuditLogActorApiKeyType.ServiceAccount,
                _ => null,
            };
        }
    }
}